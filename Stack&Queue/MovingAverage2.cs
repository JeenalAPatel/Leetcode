using System;

namespace LeetCode
{
    public class MovingAverage2
    {
        private int[] arr;
        private int count=0;
        private int sum = 0;
        private int head = 0;
        private int _size;
        public MovingAverage2(int size)
        {
            _size = size;
            arr = new int[_size];
        }
        public double Next(int val)
        {
            count += 1;
            int tail = (head + 1) % _size;
            sum = sum - arr[tail] + val;
            head = (head + 1) % _size;
            arr[head] = val;
            return sum / (double)Math.Min(_size, count);

        }
    }
}