namespace DataStructures
{
    public class Queue
    {
        private int[] elements;
        private int rear;
        private int max;
        public Queue(int size)
        {
            elements = new int[size];
            rear = -1;
            max = size;
        }
        public void Enqueue(int value)
        {
            if(rear == max - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            Console.WriteLine("ENQUEUEING ELEMENT: "+value);
            elements[++rear] = value;
        }
        public int Dequeue()
        {
            if(rear == -1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            Console.WriteLine("REMOVING ELEMENT: " + elements[rear]);
            return elements[rear--];
        }
        public bool isEmpty()
        {
            return rear == -1;
        }
        public int peek()
        {
            if (rear == -1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            Console.WriteLine("PEEK ELEMENT: ");
            return elements[rear];
        }
        public void displayQueue()
        {

            if(rear == -1)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("DISPLAYING QUEUE ELEMENTS");
            for(int i = 0; i <= rear ; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(3);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.displayQueue();
            q.Dequeue();
            q.Enqueue(40);
            q.displayQueue();
            q.isEmpty();
            Console.ReadKey();
        }
    }
}
