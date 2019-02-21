using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WinnerOfAnElection
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] votes = { "chris", "anna", "anna", "chris", "chris", "jackie", "jamie", "jamie", "anna" };

            string winningCandidate = FindWinner (votes);

            Console.WriteLine (winningCandidate);
        }

        static string FindWinner (string[] votes)
        {
            Dictionary<string, int> candidatesWithVotes = new Dictionary<string, int> ();

            for (int i = 0; i < votes.Length; i++)
            {
                if (candidatesWithVotes.ContainsKey (votes[i]))
                {
                    candidatesWithVotes[votes[i]] = candidatesWithVotes[votes[i]] + 1;
                }
                else
                {
                    candidatesWithVotes.Add (votes[i], 1);
                }
            }

            // one liner - the time complexity of the sort operation stays the typical for QuickSort O(N*logN) average / O(N2) worst case.
            var winner = candidatesWithVotes.OrderBy(c => c.Key).Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            return winner;

            // classic approach
            /* List<string> winnerNames = new List<string> ();
            //int tmpMaxVote = 0;

            foreach (KeyValuePair<string, int> candidate in candidatesWithVotes)
            {
                if (candidate.Value >= tmpMaxVote)
                {
                    winnerNames.Add (candidate.Key);

                    tmpMaxVote = candidate.Value;
                }
            }

            string winner;
            if(winnerNames.Count > 1)
            {
                winner = winnerNames.OrderBy(c => c).Last();
            }
            else
            {
                winner = winnerNames.First();
            }

            return winner; */
        }
    }
}