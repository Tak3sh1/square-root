using System;

class Solution {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(HasExactlyThreeDivisors(n));
    }

    private static bool HasExactlyThreeDivisors(int n) {
      
        int root = (int)Math.Sqrt(n);
        
       
        if (root * root != n) {
            return false;
        }
        
        return IsPrime(root);
    }

    private static bool IsPrime(int num) {
        if (num <= 1) return false;
        if (num <= 3) return true;
        if (num % 2 == 0 || num % 3 == 0) return false;

        for (int i = 5; i * i <= num; i += 6) {
            if (num % i == 0 || num % (i + 2) == 0) return false;
        }
        
        return true;
    }
}