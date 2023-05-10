using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinder
{
    public class WordFinder : IWordFinder
    {

        //using for and arrays for best performance
        //another less performing approach would be to use linq to find horizontal words, then transpose the matrix, and finally find vertical words using linq on the transposed matrix
        private string[] _matrix;

        public WordFinder(IEnumerable<string> matrix)
        {
            _matrix = matrix.ToArray();
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var wordsToFind = wordstream.ToList();
            var foundWords = new Dictionary<string, int>();

            int lines = _matrix.Length;
            int cols = lines > 0 ? _matrix.First().Length : 0;

            foreach (var wordToFind in wordsToFind)
            {
                //horizontal seach
                for (int lineCounter = 0; lineCounter < lines; lineCounter++)
                {
                    for (int colCounter = 0; colCounter < cols; colCounter++)
                    {
                        int comparerCounter = 0;
                        int comparerCounterOffset = colCounter + comparerCounter;
                        int limit = cols < wordToFind.Length ? cols : wordToFind.Length;
                        while (comparerCounterOffset < cols
                            && comparerCounter < wordToFind.Length
                            && _matrix[lineCounter][comparerCounterOffset] == wordToFind[comparerCounter])
                        {
                            comparerCounter++;
                            comparerCounterOffset++;
                        }
                        if (comparerCounter == wordToFind.Length)
                        {
                            CountFoundWord(foundWords, wordToFind);

                            colCounter = comparerCounterOffset;
                        }
                    }
                }

                //vertical seach
                for (int colCounter = 0; colCounter < cols; colCounter++)
                {
                    for (int lineCounter = 0; lineCounter < lines; lineCounter++)
                    {
                        int comparerCounter = 0;
                        int comparerCounterOffset = lineCounter + comparerCounter;
                        while (comparerCounterOffset < lines 
                            && comparerCounter < wordToFind.Length 
                            && _matrix[comparerCounterOffset][colCounter] == wordToFind[comparerCounter])
                        {
                            comparerCounter++;
                            comparerCounterOffset++;
                        }
                        if (comparerCounter == wordToFind.Length)
                        {
                            CountFoundWord(foundWords, wordToFind);

                            lineCounter = comparerCounterOffset;
                        }
                    }
                }

            }

            return foundWords.OrderByDescending(x => x.Value).Take(10).Select(x => x.Key); //take top 10 most repited words
        }

        private void CountFoundWord(Dictionary<string, int> foundWords, string word)
        {
            if (foundWords.ContainsKey(word))
            {
                foundWords[word]++;
            }
            else
            {
                foundWords.Add(word, 1);
            }
        }
    }
}
