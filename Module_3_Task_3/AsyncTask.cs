using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Module_3_Task_3
{
    public class AsyncTask
    {
        private const string _filepath = "textfile.txt";

        public async Task<string> ReadFileAsync(string filepath)
        {
            var fileContent = await File.ReadAllTextAsync(filepath);
            return fileContent;
        }

        public async Task<string> GetWorldAsync()
        {
            return await Task.Run(() => "World");
        }

        public async Task<string> GetFullText()
        {
            var tasks = new List<Task<string>>();
            tasks.Add(ReadFileAsync(_filepath));
            tasks.Add(GetWorldAsync());

            var completedTask = await Task.WhenAll(tasks);
            return string.Join(", ", completedTask);
        }
    }
}