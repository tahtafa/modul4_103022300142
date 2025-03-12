using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300142
{
    internal class FanLaptop
    {
        public enum State { Quiet, Balanced, Performance, Turbo }
        public enum trigger { up, down, shortcut }
        public State currentState;

        public FanLaptop()
        {
            currentState = State.Quiet;
            Console.WriteLine("Fan laptop sedang dalam keadaan Quiet");
        }
        public void setState(trigger state)
        {
            switch (state)
            {
                case trigger.up:
                    if (currentState == State.Quiet)
                    {
                        currentState = State.Balanced;
                        Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                    }
                    else if (currentState == State.Balanced)
                    {
                        currentState = State.Performance;
                        Console.WriteLine("Fan Balanced berubah menjadi Performance");
                    }
                    else if (currentState == State.Performance)
                    {
                        currentState = State.Turbo;
                        Console.WriteLine("Fan Performance berubah menjadi Turbo");
                    }
                    else
                    {
                        Console.WriteLine("Fan sudah dalam keadaan Turbo");
                    }

                    
                    break;
                case trigger.down:
                    if (currentState == State.Quiet)
                    {
                        
                        Console.WriteLine("Fan sudah dalam keadaan Quiet");
                    }
                    else if (currentState == State.Balanced)
                    {
                        currentState = State.Quiet;
                        Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                    }
                    else if (currentState == State.Performance)
                    {
                        currentState = State.Balanced;
                        Console.WriteLine("Fan Performance berubah menjadi Balanced");
                    }
                    else
                    {
                        
                        Console.WriteLine("Fan sudah dalam keadaan Performance");
                    }

                   
                    break;


                case  trigger.shortcut:
                    if (currentState == State.Quiet)
                    {
                        currentState = State.Turbo;
                        Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                    }
                    else if (currentState == State.Balanced)
                    {
                        
                        Console.WriteLine("Fan sudah dalam keadaan Balanced");
                    }
                    else if (currentState == State.Performance)
                    {
                        
                        Console.WriteLine("Fan sudah dalam keadaan Performance");
                    }
                    else
                    {
                        currentState = State.Quiet;
                        Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                    }


                    break;

                    break;
                case  State.Turbo:

                    Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                    break;
                default:
                    Console.WriteLine("State tidak ditemukan");
                    break;
            }
        }
        //public void SetState(enum state)
        //{
        
    //} 

}
}
