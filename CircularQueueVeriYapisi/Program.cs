using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueVeriYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class CircularQueue
    {
        private int kapasite;
        private int indeks;
        private int front;
        private int rear;
        private int[] dizi;
        public CircularQueue(int kapasite)
        {
            if(kapasite<=0)
            {
                throw new Exception("Dizinin kapasitesi 0 ve 0'dan az olamaz.");
            }
            this.kapasite = kapasite;
            dizi= new int[kapasite];
            front = rear = -1;
        }
        public void Enqueue(int deger)
        {
            if(isFull()==true)
            {
                throw new Exception("Diziye eleman eklemek için yer yoktur.");
            }
            rear = (rear+1) % kapasite;
            dizi[rear]= deger;
            indeks++;
            if(front==-1)
            {
                front = 0;
            }
        }
        public int Dequeue()
        {
            if(isEmpty()==true)
            {
                throw new Exception("Dairesel kuyruk boş");
            }
            int item = dizi[front];
            if(front==rear)
            {
                front = rear = -1;
            }
            else
            {
                front = front++ % kapasite;
            }
            indeks--;
            return item;
        }
        public int peek()
        {
            if(isEmpty()==true)
            {
                throw new Exception("Dizinin son giren elemanı yok");
            }
            return dizi[front];
        }
        public bool isFull()
        {
            return kapasite == indeks;
        }
        public bool isEmpty()
        {
            return indeks == 0;
        }
        public int Size()
        {
            return indeks;
        }
}
}
