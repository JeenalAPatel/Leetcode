using System;
using System.Linq;
using System.Collections.Generic;
class TwoSum
{
            public Dictionary<int,int> dict1=new Dictionary<int, int>();   
            public TwoSum() {
        
            }
    
            public void Add(int number) {
                if(dict1.ContainsKey(number))
                {
                    dict1[number]+=1;
                }
                else{
                    dict1.Add(number,1);
                }
            }
            
            public bool Find(int value) {
                foreach (var item in dict1.Keys)
                {
                    var num=value-item;
                    if(dict1.ContainsKey(num)&&(num!=item))
                    {
                        return true;
                    }
                }
                return false;
            }
        
}