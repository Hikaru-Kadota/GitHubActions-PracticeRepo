using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitHubActions_PracticeRepo.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? PlayerChoice { get; set; }
        
        public string? ComputerChoice { get; set; }
        public string? Result { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (string.IsNullOrEmpty(PlayerChoice))
            {
                return;
            }

            var choices = new[] { "グー", "チョキ", "パー" };
            var random = new Random();
            ComputerChoice = choices[random.Next(choices.Length)];

            Result = DetermineWinner(PlayerChoice, ComputerChoice);
        }

        private string DetermineWinner(string player, string computer)
        {
            if (player == computer)
            {
                return "引き分け！";
            }

            return (player, computer) switch
            {
                ("グー", "チョキ") => "あなたの勝ち！",
                ("チョキ", "パー") => "あなたの勝ち！",
                ("パー", "グー") => "あなたの勝ち！",
                _ => "コンピューターの勝ち！"
            };
        }
    }
}
