﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheckNameSpace
{
    public static class DuplicateCheck
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static List<T> GetDuplicates<T>(this List<T> list)
        {
            var listDuplicates = new List<T>();
            var duplicates = list.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key);
            foreach (var item in duplicates)
            {
                listDuplicates.Add(item);
            }
            return listDuplicates;
        }

        public static string GetReversed(this string str)
        {
            var reversed = new string((from c in str.Select((value, index) => new { value, index })
                                       orderby c.index descending
                                       select c.value).ToArray());
            return reversed;
        }


    }
}
