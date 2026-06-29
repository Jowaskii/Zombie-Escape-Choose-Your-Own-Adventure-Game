namespace SecretAuction {
    internal class Program {
        static bool otherBidders = true;
        static Dictionary<string, int> bidders = new Dictionary<string, int>();
        static void Main(string[] args) {
            Console.WriteLine(@" 
                         ___________
                         \         /
                          )_______(
                          |""""""""""""""|_.-._,.---------.,_.-._
                          |       | | |               | | ''-.
                          |       |_| |_             _| |_..-'
                          |_______| '-' `'---------'` '-'
                          )""""""""""""""(
                         /_________\\
                       .-------------.
                      /_______________\\");
            Console.WriteLine("Welcome to the Secret Auction!\nToday's auction will be the 'Gavel of Doom'.\nIt is said that one strike of this legendary gavel can completely " +
                "eradicate anyone or anything across the entire universe.\nLet the bidding commence");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            while (otherBidders) {
                Console.WriteLine(@" 
                         ___________
                         \         /
                          )_______(
                          |""""""""""""""|_.-._,.---------.,_.-._
                          |       | | |               | | ''-.
                          |       |_| |_             _| |_..-'
                          |_______| '-' `'---------'` '-'
                          )""""""""""""""(
                         /_________\\
                       .-------------.
                      /_______________\\");
                Console.WriteLine("Please enter your name: ");
                string? name = Console.ReadLine();

                Console.WriteLine("Please enter you bid");
                int bid = Convert.ToInt32(Console.ReadLine());
                bidders[name] = bid;

                Console.WriteLine("Are there any other bidders?(yes/no)");
                string? newBidder = Console.ReadLine();

                if (newBidder == "yes") {
                    Console.Clear();
                }
                else {
                    otherBidders = false;
                }
            }
            FindHighestBid();
        void FindHighestBid() {
                int highestBid = 0;
                string winner = string.Empty;
                foreach (var bidder in bidders) {
                    if (bidder.Value > highestBid) {
                        highestBid = bidder.Value;
                        winner = bidder.Key;
                    }
                }
                Console.WriteLine($"The winner is {winner} with a bid of {highestBid.ToString("C")}");
            }
        }
    }
}
