using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities and dequeue them.
    // Expected Result: The highest priority item should be dequeued first.
    // Defect(s) Found: None if implemented correctly.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);
        
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and check FIFO order.
    // Expected Result: Items with the same priority should be dequeued in the order they were enqueued.
    // Defect(s) Found: None if implemented correctly.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue(); 
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 2);
        
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An exception should be thrown with the correct message.
    // Defect(s) Found: None if implemented correctly.
    public void TestPriorityQueue_EmptyQueueThrowsException()
    {
        var queue = new PriorityQueue();
        
        try
        {
            queue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}