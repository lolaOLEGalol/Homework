using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class HelpArr
    {
        private int Summ = 0; // 2
        private int maxCount = 0; // 2

        public HelpArr()
        {
            
        } // 1

        public HelpArr(int size, int start, int step)
        {
            int [] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    arr[i] = start;
                }
                else
                {
                    arr[i] = arr[i-1] + step;
                }
            }

            for (int i = 0; i < size; i++)
            {
                Summ += arr[i];
            }
        } // 2

        public int GetSumm()
        {
            return Summ;
        } // 2

        public int GetMaxCount()
        {
            return maxCount;
        } // 2

        public void PrintArr(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i+1}) {arr[i]}");
            }
        } // 1

        public int[] RandomArr(int size, int OT, int DO)
        {
            int[] arr = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(OT, DO);
            }
            return arr;
        } // 1

        public int CountCouple(int[] arr, int size)
        {
            int k = 0;

            for (int i = 0; i < size - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i+1] % 3 == 0)
                {
                    k++;
                }
            }
            return k;
        } // 1

        public int[] Invers(int[] arr, int size) // 2
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = -arr[i];
            }

            return arr;
        }

        public int[] Multi(int[] arr, int size, int number) // 2
        {
            for(int i = 0; i < size; i++)
            {
                arr[i] *= number;
            }

            return arr;
        }

        public void MaxCount(int[] arr, int size)
        {
            int max = arr[0];

            for (int i = 0; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == max)
                {
                    maxCount++;
                }
            }

            
        } // 2

        public void FileWrite(string vay, int number)
        {
            StreamWriter strWrt = new StreamWriter(vay, false, Encoding.ASCII);
            strWrt.WriteLine(number);
            strWrt.Flush();
            strWrt.Close();
        } // 2B

        public void FileWrite(string vay, int[] arr, int size)
        {
            StreamWriter strWrt = new StreamWriter(vay, false, Encoding.ASCII);
            for (int i = 0; i < size; i++)
            {
                strWrt.WriteLine(arr[i]);
            }
            
            strWrt.Flush();
            strWrt.Close();
        } // 2B

        public void FileRead(string vay)
        {
            if (string.IsNullOrEmpty(vay) || !File.Exists(vay)) return;

            StreamReader strRead = new StreamReader(vay);
            while (!strRead.EndOfStream)
            {
                Console.WriteLine(strRead.ReadLine());
            }
            
            strRead.Close();
        } // 2B
        public void Pause()
        {
            Console.ReadKey();
        } // 1

    }

    struct Account
    {
        private string login; // 3
        private string password; // 3

        Account (int SetLoginAndPassword)
        {
            login = "start";
            password = "start";
        } // 3

        public void SetLoginAndPassword(string loginUser, string passwordUser)
        {
            string[] tempArr = new string[2];

            login = loginUser;
            password = passwordUser;

            tempArr[0] = login;
            tempArr[1] = password;

            StreamWriter file = new StreamWriter("Account.txt", false, Encoding.ASCII);

            for (int i = 0; i < 2; i++)
            {
                file.WriteLine(tempArr[i]);
            }

            file.Flush();
            file.Close();

        } // 3

        public bool CheckLoginAndPassword(string loginUser, string passwordUser)
        {
            string tempLogin;
            string tempPassword;
            StreamReader file = new StreamReader("Account.txt");
            tempLogin = file.ReadLine();
            tempPassword = file.ReadLine();

            if (tempLogin == loginUser && tempPassword == passwordUser)
            {
                return true;
            }
            else
                return false;
        } // 3

        public void PrintLoginAndPassword()
        {
            Console.WriteLine($"login: {login}");
            Console.WriteLine($"password: {password}");
        } // 3
    }

    class HelpTwoArr
    {
        private int[,] arr = new int[10,10];
        private int minElement;
        private int maxElement;
        Random rand = new Random();

        public HelpTwoArr()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    arr[i,j] = rand.Next(0, 100);

                    if (arr[i,j] < minElement)
                    {
                        minElement = arr[i, j];
                    }

                    if (arr[i, j] > maxElement)
                    {
                        maxElement = arr[i, j];
                    }
                }
            }
        }

        public HelpTwoArr(string vay)
        {
            StreamWriter file = new StreamWriter(vay, false, Encoding.ASCII);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rand.Next(0, 100);

                    if (arr[i, j] < minElement)
                    {
                        minElement = arr[i, j];
                    }

                    if (arr[i, j] > maxElement)
                    {
                        maxElement = arr[i, j];
                    }

                    file.WriteLine(arr[i, j]);
                }
            }
            file.Flush();
            file.Close();
        } // 4B

        public void ReadArrFILE(string vay)
        {
            StreamReader file = new StreamReader(vay);


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = Convert.ToInt32(file.ReadLine());
                }
            }
        }

        public int Summ()
        {
            int summ = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    summ += arr[i, j];
                }
            }

            return summ;
        }

        public int Summ(int maxNumber)
        {
            int summ = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(arr[i,j] > maxNumber)
                    {
                        summ += arr[i, j];
                    }
                }
            }

            return summ;
        }

        public void returnMaxCount(out int i, out int j)
        {
            i = arr[0, 0];
            j = arr[0, 0];

            for (int i1 = 0; i1 < 10; i++)
            {
                for (int j1 = 0; j1 < 10; j++)
                {
                    if (arr[i, j] > maxElement)
                    {
                        i = i1;
                        j = j1;
                    }
                }
            }
        }

        public int GetMaxElement()
        {
            return maxElement;
        }

        public int GetMinElement()
        {
            return minElement;
        }

        public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
    }
}
