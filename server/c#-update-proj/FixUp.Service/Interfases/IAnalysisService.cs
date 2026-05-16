using FixUp.Service.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUp.Service.Interfases
{
    public interface IAnalysisService
    {
        //The function gets text and analyze which category the text match 
        //returns: categoryid and confidence in the dedection
        (int CategoryId, double Confidence) DetectCategoryId(string text);
        //The function get the text and gives back dictionary the key is words and
        //the value is the times the word appear
        Dictionary<string, int> GetWordCounts(string text);
        //the function gets image and text to analyzed the problem and returns the categoryid with confidence
        Task<CategoryAnalystDto> AnalyzeRequestAsync(IFormFile image,string prompt);
    }
}
