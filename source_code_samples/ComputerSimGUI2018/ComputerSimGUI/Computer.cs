using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerSimGUI
{
    public class Computer
    {
        // constants
        private const int READ = 10;
        private const int WRITE = 11;
        private const int LOAD = 20;
        private const int STORE = 21;
        private const int ADD = 30;
        private const int SUB = 31;
        private const int DIV = 32;
        private const int MUL = 33;
        private const int BR = 40;
        private const int BRNEG = 41;
        private const int BRZERO = 42;
        private const int HALT = 43;

        // fields
        private int[] memory;
        private int accumulator;
        private int program_counter;
        private MainForm _mainForm;
       

        // properties
        public int[] Memory
        {
            get { return memory; }
        }


        // default constructor
        public Computer(MainForm mainform)
        {
            memory = new int[100];
            accumulator = 0;
            program_counter = 0;
            _mainForm = mainform;
   
        }

       

        public void Execute()
        {
            program_counter = 0;
            bool keep_going = true;
            int instruction = 0;
            int opcode = 0;
            int operand = 0;

            while (keep_going)
            {
                _mainForm.ProgramCounterTextBox = program_counter.ToString();

                instruction = memory[program_counter++];
                opcode = instruction / 100;
                operand = instruction % 100;

                _mainForm.OpCodeTextBox = opcode.ToString();
                _mainForm.OperandTextBox = operand.ToString();




                switch (opcode)
                {

                    case WRITE:
                        {
                            MessageBox.Show(memory[operand].ToString());
                            break;
                        }

                    case STORE:
                        {
                           
                            memory[operand] = accumulator;
                            break;
                        }

                    case LOAD:
                        {
                           
                            accumulator = memory[operand];
                            _mainForm.AccumulatorTextBox = accumulator.ToString();
                            break;
                        }
                    case READ:
                        {

                            memory[operand] = Int32.Parse(_mainForm.EntryTextBox);

                            break;
                        }

                    case MUL:
                        {
                            
                            accumulator *= memory[operand];
                            _mainForm.AccumulatorTextBox = accumulator.ToString();
                            break;
                        }


                    case HALT:
                        {
                           
                            keep_going = false;
                            break;
                        }
                    default:
                        {
                           

                            break;
                        }

                } // end switch




            } // end while

            
        }


       public void LoadProgram(int[] instructions)
        {
            WipeMemory();
            
            for(int i = 0; i < instructions.Length; i++)
            {
                memory[i] = instructions[i];
            }

        }


        

        private void WipeMemory()
        {
            for(int i = 0; i < memory.Length; i++)
            {
                memory[i] = 0;
            }
        }


    } // end class
}
