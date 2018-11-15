using AsyncAwaitQuiz;
using NUnit.Framework;

namespace Tests
{
    public class Question9Tests
    {
        /*
            The answer is B
            
            Test 1
            Test 1.5
            Test 2

            The code will invoke Operation1Async which writes "Test 1" to the console.
            It then waits 5 seconds, writes "Test 1.5" to the console and then returns a completed task to the calling method.
            The calling method (Run) awaits the task. The task is already completed, so it can immediately continue execution.
            Operation2Async is then invoked, which writes "Test 2" to the console and begins an HTTP request.
            "await" means that execution of the method is paused whilst the network I/O is taking place.
            As "await" is non-blocking, the thread will continue to execute the calling method (Run). 
            Operation2Async returns an incomplete task to Run and allows the thread to continue execution until Operation2 is complete.
            "await" allows the thread to continue execution in the calling method (the unit test) until Run is complete. Unfortunately, Run doesn't return a task, so the calling method can't know when it's complete or await it.
            The unit test execution completes before the HTTP request is complete, so execution does not continue afterwards in Operation2Async, so "Test 2.5" isn't written to the console.
            Execution of Run doesn't continue either, so Operation3 isn't invoked and "Test 3" isn't written to the console.
        */

        [Test]
        public void Run()
        {
            Question9.Run();
        }
    }
}
