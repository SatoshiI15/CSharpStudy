using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

List<int> nums = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
};

IEnumerable<int> evensList = nums.Where(n => n % 2 == 0).ToList();

int[] evensArray = nums.Where(n => n % 2 == 0).ToArray();

foreach (var n in evensList)
{
    Console.WriteLine("{0} ", n);
}
