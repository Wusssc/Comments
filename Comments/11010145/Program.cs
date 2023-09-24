using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11010145
{
    interface IPass //介面IPass，用來判斷是否及格
    {
        int Score { get; set; } //及格分數
        string Pass(int grrade); //判斷及格的方法
    }
    interface ILevel //介面ILevel，用來判斷等第評語
    {
        int High { get; set; } //高標分數
        int Low { get; set; } //低標分數
        string Level(int grade); //判斷等第評語的方法
    }
    class CMStudent : IPass, ILevel //類別CMStudent(研究生)，實作IPass, ILevel的介面
    {
        private int score = 70; //研究生及格分數
        public int Score //及格分數輸入
        {
            get { return score; } //取值 
            set { score = value;} //給值
        }

        public string Pass(int grrade) //判斷及格的方法
        {
            if (grrade >= Score) //如果分數大於及格分數
                return "及格"; //回傳"及格"
            else
                return "不及格"; //否則回傳"不及格"
        }

        private int high = 90; //高標分數
        private int low = 69; //低標分數
        public int High //高標分數輸入
        {
            get { return high; } //取值
            set { high = value; } //給值
        }
        public int Low //低標分數輸入
        {
            get{ return low; } //取值
            set{ low = value; } //給值
        }
        public string Level(int grade) //判斷等第評語的方法
        {
            if (grade >= high) //如果分數大於等於高標
                return "表現優異"; //回傳"表現優異"
            else if (grade < low) //如果分數低於低標
                return "有待加強"; //回傳"有待加強"
            else //以上條件都不滿足的話
                return "差強人意"; //回傳"差強人意"
        }
    }
    class CUStudent : IPass, ILevel//類別CUStuden(大學生)，實作IPass, ILevel的介面
    {
        private int score = 60; //大學生及格分數
        public int Score //及格分數輸入
        {
            get { return score; } //取值 
            set { score = value; } //給值
        }

        public string Pass(int grrade) //判斷及格的方法
        {
            if (grrade >= Score) //如果分數大於及格分數
                return "及格"; //回傳"及格"
            else
                return "不及格"; //否則回傳"不及格"
        }

        private int high = 80; //高標分數
        private int low = 55; //低標分數

        public int High //高標分數輸入
        {
            get { return high; } //取值
            set { high = value; } //給值
        }
        public int Low //低標分數輸入
        {
            get { return low; } //取值
            set { low = value; } //給值
        }
        public string Level(int grade) //判斷等第評語的方法
        {
            if (grade >= high) //如果分數大於等於高標
                return "表現優異"; //回傳"表現優異"
            else if (grade < low) //如果分數低於低標
                return "有待加強"; //回傳"有待加強"
            else //以上條件都不滿足的話
                return "差強人意"; //回傳"差強人意"
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入您的身分(大學生、研究生)：");
            string word = Console.ReadLine(); //將輸入字串丟給word
            if (word == "研究生") //如果word為研究生
            {
                CMStudent master = new CMStudent(); //建立並配置記憶體空間
                Console.Write("請輸入學期成績(0~100分)：");
                int a = Convert.ToInt32(Console.ReadLine()); //將輸入分數丟給a
                Console.WriteLine("分數：" + master.Pass(a)); //輸出及格或不及格，將分數交給master.Pass執行
                Console.WriteLine("評語：" + master.Level(a)); //輸出評語，將分數交給master.Level執行
            }
            else if (word == "大學生") //如果word為大學生
            {
                CUStudent studen = new CUStudent(); //建立並配置記憶體空間
                Console.Write("請輸入學期成績(0~100分)：");
                int a = Convert.ToInt32(Console.ReadLine()); //將輸入分數丟給a
                Console.WriteLine("分數：" + studen.Pass(a)); //輸出及格或不及格，將分數交給studen.Pass執行
                Console.WriteLine("評語：" + studen.Level(a)); //輸出評語，將分數交給studen.Level執行
            }
            else
            {
                Console.WriteLine("身分錯誤，請再輸入一次"); //如果輸入身分不符合，就輸出"身分錯誤，請再輸入一次"
            }
            Console.Read();
        }
    }
}
