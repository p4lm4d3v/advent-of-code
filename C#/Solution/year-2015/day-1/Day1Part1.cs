﻿namespace Solution.year_2015.day_1
{
    public static class Day1Part1
    {
        public static int Proccess(string input)
        {
            int currentFloor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char s = input[i];
                if (s == '(') currentFloor++;
                else if (s == ')') currentFloor--;
            }
            return currentFloor;
        }
    }
    public static class Day1Part1Test
    {
        public static int Test1() => Day1Part1.Proccess("(())");
        public static int Test2() => Day1Part1.Proccess("()()");
        public static int Test3() => Day1Part1.Proccess("(((");
        public static int Test4() => Day1Part1.Proccess("(()(()(");
        public static int Test5() => Day1Part1.Proccess("))(((((");
        public static int Test6() => Day1Part1.Proccess("())");
        public static int Test7() => Day1Part1.Proccess("))(");
        public static int Test8() => Day1Part1.Proccess(")))");
        public static int Test9() => Day1Part1.Proccess(")())())");
    }
}
