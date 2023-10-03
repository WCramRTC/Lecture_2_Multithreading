using System.Diagnostics;

namespace Lecture_2_Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } // Form1

        private void btnSync_Click(object sender, EventArgs e)
        {

            ShortProcess();
            LongProcess();

        } // btnSync_Click

        public void ShortProcess()
        {
            DisplayToRTB("Start short process");
            DisplayToRTB("Stop short process");
        }

        public void LongProcess()
        {
            DisplayToRTB("Start LONG Process");

            // Use Thread SLeep to lock our thread for 6 seconds
            Thread.Sleep(5000);

            DisplayToRTB("End LONG Process");
        }

        public async void DisplayToRTB(string message)
        {
            rtbDisplay.Text += message + "\n";
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            ShortProcess();
            LongAsync(1);
        } // btnAsync_Click



        public async void LongAsync(int number)
        {
            Stopwatch sw = new Stopwatch();
            DisplayToRTB($"Start LONG Process : {number}");
            sw.Start();
            // Await the Delayed Thread before returning back to the main thread
            await Task.Delay(5000);
            sw.Stop();
            DisplayToRTB($"End LONG Process : {number} : {sw.ElapsedMilliseconds}");
        }



        private void btnMultipleAsync_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumberOfLoops.Text);
            // Stopwatch
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < number; i++)
            {
                sw.Start();
                LongAsync(i);
                sw.Stop();
                DisplayToRTB(sw.ElapsedMilliseconds.ToString());
            }
        }

        // Return Values ------------------------------------------------

        private async void btnReturnValue_Click(object sender, EventArgs e)
        {

            DisplayToRTB("Adding Two Numbers : 6 + 10");

            double addNumbers = await AddNumbers(6, 10);

            DisplayToRTB("Result : " + addNumbers);


        } // btnReturnValue_Click

        // async
        // await

        // Add 2 numbers together

        public async Task<double> AddNumbers(double num1, double num2)
        {
            await Task.Delay(2000);

            return num1 + num2;
        }

      

        // Call back information

        private void Callback_Click(object sender, EventArgs e)
        {

            CallBackEx();
        }  // Callback_Click

        public async void CallBackEx()
        {
            Task<int> call = Task.Run(async () =>
            {
                await Task.Delay(2000);
                return 23;
            });

            await call.ContinueWith(async t =>
            {
                rtbDisplay.Text = t.ToString();
            });

        }

        public async void CallBackExampleOG()
        {
            Task<int> call = Task.Run(
                async () =>
            {
                await Task.Delay(3000);
                return 10;
            });

            await call.ContinueWith(t =>
            {
                DisplayToRTB(t.Result + t.Result + "");
            });
        }

        public void ExampleCode()
        {

            //Task<int> task = Task.Run(async () =>
            //{
            //    DisplayToRTB("Task is running");
            //    await Task.Delay(3000);
            //    DisplayToRTB("Task is is finished");

            //    return 5000;
            //});

            //// The argument passed in, represents the value that is returned from the instanced Task
            //// you can get the result with the .Result property
            //await task.ContinueWith( returnedValueFromTask =>
            //{
            //    DisplayToRTB("Continue is running");
            //    int sum = returnedValueFromTask.Result + returnedValueFromTask.Result;
            //    DisplayToRTB("Continue is finished");
            //    DisplayToRTB(sum.ToString());
            //});

            // Super summed up callback
            Task doubleSum = Task.Run(async () => // Created a task
            {
                DisplayToRTB("Start Run");
                await Task.Delay(3000); // I delayed the task by 3 seconds
                return 2.5; // I returned a value of 2.5
            }).ContinueWith(async t => // I added a CALLBACK with .ContinueWith() directly to my original Task
            {
                DisplayToRTB("Start Sum");
                await Task.Delay(3000);
                DisplayToRTB((t.Result * t.Result).ToString());// I squared the result and returned it
            });


            //int number = await task;

            //DisplayToRTB(number.ToString());
        }



        private void Clear_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "";
        }

        private async void btnAddNumbers_Click(object sender, EventArgs e)
        {
            LoopAsync();
            
        }

        public async void LoopAsync()
        {
            Stopwatch sw = new Stopwatch();
            // Start my stopwatch
            sw.Start(); // Starts the stop watch

            int multiplier = 10 * 10 * 10 * 10 * 10;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Random rand = new Random();
                    int randomNum1 = rand.Next(0, 1000000);
                    Random rand2 = new Random(randomNum1);
                    int randomNum2 = rand.Next(0, randomNum1);
                    Random rand3 = new Random(randomNum2);
                    int randomNum3 = rand.Next(0, randomNum2);

                }
                DisplayToRTB("The for loop just stopped running");
            });

            // Stop my stopwatch
            sw.Stop(); // Stops the stop watch

            DisplayToRTB(sw.ElapsedMilliseconds.ToString());
        } // LoopAsync

        public async Task<double> AddNumbersExtreme(double number1, double number2)
        {
            rtbDisplay.Text = "Is Running";
            Stopwatch sw = new Stopwatch();
            int sum = 0;

            sw.Start();
            await Task.Run(() =>
            {
                for (int i = 0; i < 5000000; i++)
                {
                    Random rand = new Random();
                    int randomNum1 = rand.Next(0, 2000);
                    Random rand2 = new Random(randomNum1);
                    int randomNum2 = rand.Next(0, randomNum1);
                    Random rand3 = new Random(randomNum2);
                    int randomNum3 = rand.Next(0, randomNum2);

                    sum += randomNum1;

                }
               DisplayToRTB("The for loop just stopped running");
            });
            sw.Stop();
            DisplayToRTB(sw.ElapsedMilliseconds.ToString());

            return sum;
        }

        // Infinite Loops
        // Thread.Wait

    } // class

} // namespace