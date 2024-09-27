var solution = new Solution();
var res = solution.ClimbStairs(45);
Console.WriteLine(res);
Console.ReadLine();
public class Solution
{
    public int ClimbStairs(int n)
    {
        // Each staircase can be climbed using only 1 step
        double result = 1;       

        if (n % 2 == 0) 
        {
            // Staircase can be climbed using only 2 step
            result++;
        }

        // Possible quantity of 2 steps
        int NumberTwoSteps = n / 2;
        // iterate possible solutions based on ammount of '2' in it 
        for (int twoInSolution = 1; twoInSolution <= NumberTwoSteps; twoInSolution++)
        {
            var twoSum = twoInSolution * 2;
            var oneInSolution = n - twoSum;

            double secondPart = Factorial(oneInSolution);
            double firstPart = Factorial(twoInSolution);
            double N = Factorial(twoInSolution+oneInSolution);

            //Number of permutations = fact( sum of '2' and '1') / fact( Quantity of '2') * fact( Quantity of '1') 
            if (secondPart != 0 && firstPart != 0 && N != 0)
                result += N / (firstPart * secondPart);            
        }
        return (int)result;
    }
    double Factorial(int n)
    {   
        if(n == 0) 
            return 0;
        double result = 1;
        for (int i = n; i > 0; i--)
        {
            result = result * i;
        }
        return result;
    }
}