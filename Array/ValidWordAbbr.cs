using System;
using System.Linq;
using System.Collections.Generic;
class ValidWordAbbr
{
    public string[] dict = new string[]{};
    public Dictionary<string,List<string>> dict2=new Dictionary<string,List<string>>();
    public ValidWordAbbr(string[] dictionary) {
        dict=dictionary;
        
    }
    
    public bool IsUnique(string word) {
        var abWord=getWord(word);
        if(!dict2.ContainsKey(abWord))
        {
            return true;
        }
        else
        {
            foreach (var item in dict2.Values)
            {
                if(word.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
    public string getWord(string word)
    {
        return $"{word[0]}{word.Length-2}{word[word.Length-1]}";
        
    }
    public void getdata(string[] dict)
    {
        for (int i = 0; i < dict.Length; i++)
        {
            var str = getWord(dict[i]);
            if(dict2.ContainsKey(str))
            {
                dict2[str].Add(dict[i]);
            }
            else
            {
                dict2.Add(str,new List<string>(){dict[i]});
            }
        }
        
    }

}