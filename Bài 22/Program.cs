using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bài_22
{
    class BankAccount
    {
        private string owner { get; set; }
        private decimal balance { get; set; }
        public BankAccount(string owner, decimal balance)
        {
            this.owner = owner;
            this.balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Đã nạp {amount:C} vào tài khoản của {owner}. Số dư mới: {balance:C}");
            }
            else
            {
                Console.WriteLine("Số tiền nạp phải lớn hơn 0.");
            }
        }
        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= (double)balance)
            {
                balance -= (decimal)amount;
                Console.WriteLine($"Đã rút {amount:C} từ tài khoản của {owner}. Số dư mới: {balance:C}");
                return true;
            }
            else
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0 và nhỏ hơn hoặc bằng số dư hiện tại.");
                return false;
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Chủ tài khoản: {owner}");
            Console.WriteLine($"Số dư: {balance:C}");
        }

        public void Transfer(BankAccount targetAccount, decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                targetAccount.Deposit(amount);
                Console.WriteLine($"Đã chuyển {amount:C} từ tài khoản của {owner} sang tài khoản của {targetAccount.owner}. Số dư mới: {balance:C}");
            }
            else
            {
                Console.WriteLine("Số tiền chuyển phải lớn hơn 0 và nhỏ hơn hoặc bằng số dư hiện tại.");
            }
        }

        public void CalculateInterest(decimal interestRate)
        {
            if (interestRate > 0)
            {
                decimal interest = balance * interestRate / 100;
                balance += interest;
                Console.WriteLine($"Đã tính lãi suất {interestRate}% cho tài khoản của {owner}. Số dư mới: {balance:C}");
            }
            else
            {
                Console.WriteLine("Lãi suất phải lớn hơn 0.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");

            BankAccount account = new BankAccount("Tổng Tài Quang", 500000);
            account.DisplayAccountInfo();

            Console.WriteLine("Nhập số tiền nạp:");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.WriteLine("Thông tin tài khoản sau khi nạp tiền:");
            account.DisplayAccountInfo();

            Console.WriteLine("Nhập số tiền rút:");
            double withdrawAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount);

            Console.WriteLine("Thông tin tài khoản sau khi rút tiền:");
            account.DisplayAccountInfo();

            Console.WriteLine("Nhập số tiền rút:");
            double withdrawAmount2 = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawAmount2);

            Console.WriteLine("Thông tin tài khoản sau khi rút tiền:");
            account.DisplayAccountInfo();

            Console.WriteLine("Nhập lãi suất (%):");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            account.CalculateInterest(interestRate);

            Console.WriteLine("Thông tin tài khoản sau khi tính lãi:");
            account.DisplayAccountInfo();

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();

        }
    }
}
