using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/**
 * Await is like join in java ,it will wait for other thread to complete
 */
namespace ManishConsoleApp.async
{
    public class SampleAsync
    {

        public static async Task Main() {

            await DoAsyncOperationAsync(1);
            await DoAsyncOperationAsync(2);
            Task t3 = DoAsyncOperationAsync(3);
            Task t4 = DoAsyncOperationAsync(4);
            Task t5 = DoAsyncOperationAsync(5);
            Task t6 = DoAsyncOperationAsync(6);
            await Task.WhenAll(t3,t4,t4,t5,t6);


        }



        public static async Task<int> DoAsyncOperationAsync(int n)
        {
            // Do some long-running asynchronous operation, for example:
            await Task.Delay(2000); // Delay for 1 second
            Console.WriteLine($"Inside DoAsyncOperationAsync-{n}");
            // Return some result
            return 42;
        }

    }
}
