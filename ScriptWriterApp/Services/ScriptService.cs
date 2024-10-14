using System.IO;
using System.Threading.Tasks;

namespace ScriptWriterApp.Services
{
    public class ScriptService
    {
        // Save the script
        public async Task SaveScriptAsync(string scriptName, string scriptContent)
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, $"{scriptName}.txt");
            await File.WriteAllTextAsync(filePath, scriptContent);
        }

        // Load the script
        public async Task<string> LoadScriptAsync(string filePath)
        {
            return await File.ReadAllTextAsync(filePath);
        }
    }
}
