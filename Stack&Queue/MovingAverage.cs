using System;
using System.Collections.Generic;
using System.Net.Http;

namespace LeetCode
{
    
    public class MovingAverage
    {
        private readonly Queue<int> _queue;
        private readonly int _size;
        private int _sum;
        
        public MovingAverage(int size)
        {
            _queue = new Queue<int>(size);
            _size = size;
            _sum = 0;
        }
        
        public double Next(int val)
        {
            if (_queue.Count == _size)
            {
                _sum -= _queue.Dequeue();
            }

            if (_queue.TryPeek(out var result))
            {
                Console.WriteLine(result);
            }

            _sum += val;
            _queue.Enqueue(val);
            

            return (double)_sum / _queue.Count;
        }
    }
}