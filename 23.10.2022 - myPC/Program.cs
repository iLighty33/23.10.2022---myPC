using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _23._10._2022___myPC
{

    public class myPC
    {        
        private int quantity = 0;
        public int PCQuantity {
            get { return quantity;}
            set { quantity = value; } 
   
        }

        public void WrongQuantity()
        {
            Console.WriteLine("Wrong quantity");
            Console.ReadKey();
            return;
        }

        // myMonitors

         public int MyMonitor
        {
            get {
                if (_myMonitors <= _myMonitorsMaxQuantity)
                {
                    return _myMonitors;
                }
                else
                    return 0;
            }
            set { _myMonitors = value; }

        }

        public string MyMonitorName
        {
            get { return _myMonitorType; }
            set { _myMonitorType = value; }
        }

        private int _myMonitorsMaxQuantity = 3;
        private int _myMonitors = 0;
        private string _myMonitorType = "";


        // myKeyboard
        public int MyKeyboard
        {
            get
            {
                if (_myKeyboads <= _myKeyboadsMaxQuantity)
                {
                    return _myKeyboads;
                }
                else
                    return 0;
            }
            set { _myKeyboads = value; }

        }

        public string MyKeyboardName
        {
            get { return _myKeyboadType; }
            set { _myKeyboadType = value; }
        }

        private int _myKeyboadsMaxQuantity = 1;
        private int _myKeyboads = 0;
        private string _myKeyboadType = "";

        // myMouse

        public int MyMouse
        {
            get
            {
                if (_myMouses <= _myMousesMaxQuantity)
                {
                    return _myMouses;
                }
                else
                    return 0;
            }
            set { _myMouses = value; }

        }

        public string MyMouseName
        {
            get { return _myMouseType; }
            set { _myMouseType = value; }
        }

        private int _myMousesMaxQuantity = 1;
        private int _myMouses = 0;
        private string _myMouseType = "";
    }

    public class BuildMyPCBox : myPC
    {
        // myMotherboard

        public int MyMotherboard
        {
            get
            {
                if (_myMotherboards <= _myMotherboardsMaxQuantity)
                {
                    return _myMotherboards;
                }
                else
                    return 0;
            }
            set { _myMotherboards = value; }

        }

        public string MyMotherboardName
        {
            get { return _myMotherboardType; }
            set { _myMotherboardType = value; }
        }

        private int _myMotherboardsMaxQuantity = 1;
        private int _myMotherboards = 0;
        private string _myMotherboardType = "";

        // myMemory

        public int MyMemory
        {
            get
            {
                if (_myMemories <= _myMemoriesMaxQuantity)
                {
                    return _myMemories;
                }
                else
                    return 0;
            }
            set { _myMemories = value; }

        }

        public string MyMemoryName
        {
            get { return _myMemoryType; }
            set { _myMemoryType = value; }
        }


        private int _myMemoriesMaxQuantity = 1;
        private int _myMemories = 0;
        private string _myMemoryType = "";

        // myProcessor

        public int MyProcessor
        {
            get
            {
                if (_myProcessors <= _myProcessorsMaxQuantity)
                {
                    return _myProcessors;
                }
                else
                    return 0;
            }
            set { _myProcessors = value; }

        }

        public string MyProcessorName
        {
            get { return _myProcessorType; }
            set { _myProcessorType = value; }
        }

        private int _myProcessorsMaxQuantity = 1;
        private int _myProcessors = 0;
        private string _myProcessorType = "";

        // myHardDrive

        public int MyHardDrive
        {
            get
            {
                if (_myHardDrive <= _myHardDriveMaxQuantity)
                {
                    return _myHardDrive;
                }
                else
                    return 0;
            }
            set { _myHardDrive = value; }

        }
        public string MyHardDriveName
        {
            get { return _myHardDriveType; }
            set { _myHardDriveType = value; }
        }

        private int _myHardDriveMaxQuantity = 1;
        private int _myHardDrive = 0;
        private string _myHardDriveType = "";

        // myPowerSupply

        public int MyPowerSupply
        {
            get
            {
                if (_myPowerSupplies <= _myPowerSuppliesMaxQuantity)
                {
                    return _myPowerSupplies;
                }
                else
                    return 0;
            }
            set { _myPowerSupplies = value; }

        }

        public string MyPowerSupplyName
        {
            get { return _myPowerSupplyType; }
            set { _myPowerSupplyType = value; }
        }

        private int _myPowerSuppliesMaxQuantity = 1;
        private int _myPowerSupplies = 0;
        private string _myPowerSupplyType = "";

        // myBox

        public int MyBox
        {
            get
            {
                if (_myBoxes <= _myBoxesMaxQuantity)
                {
                    return _myBoxes;
                }
                else
                    return 0;
            }
            set { _myBoxes = value; }

        }
        public string MyBoxName
        {
            get { return _myBoxType; }
            set { _myBoxType = value; }
        }

        private int _myBoxesMaxQuantity = 1;
        private int _myBoxes = 0;
        private string _myBoxType = "";

        // myVdeocards

        public int MyVideocard
        {
            get
            {
                if (_myVideocards <= _myVideocardsMaxQuantity)
                {
                    return _myVideocards;
                }
                else
                    return 0;
            }
            set { _myVideocards = value; }

        }
        public string MyVideoCardName
        {
            get { return _myVideoCardType; }
            set { _myVideoCardType = value; }
        }

        private int _myVideocardsMaxQuantity = 2;
        private int _myVideocards = 0;
        private string _myVideoCardType = "";

        // myCDRom

        public int MyCDRom
        {
            get
            {
                if (_myCDRoms <= _myCDRomsMaxQuantity)
                {
                    return _myCDRoms;
                }
                else
                    return 0;
            }
            set { _myCDRoms = value; }

        }

        public string MyCDRomName
        {
            get { return _myCDRomType; }
            set { _myCDRomType = value; }
        }

        private int _myCDRomsMaxQuantity = 1;
        private int _myCDRoms = 0;
        private string _myCDRomType = "";

        // myFlasCard

        public int MyFlashCard
        {
            get
            {
                if (_myFlashCards <= _myFlashCardsMaxQuantity)
                {
                    return _myFlashCards;
                }
                else
                    return 0;
            }
            set { _myFlashCards = value; }

        }

        public string MyFlashCardName
        {
            get { return _myFlashCardType; }
            set { _myFlashCardType = value; }
        }

        private int _myFlashCardsMaxQuantity = 1;
        private int _myFlashCards = 0;
        private string _myFlashCardType = "";

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create WorkPlace

            myPC myPC = new myPC();

            myPC.MyMonitor ++;
            myPC.MyMonitorName = "LG";

            myPC.MyKeyboard ++;
            myPC.MyKeyboardName = "A4";

            myPC.MyMouse ++;
            myPC.MyMouseName = "SteelSeries";

            BuildMyPCBox myPCBox = new BuildMyPCBox();

            myPCBox.MyMotherboard ++;
            myPCBox.MyMotherboardName = "ASRock";

            myPCBox.MyMemory ++;
            myPCBox.MyMemoryName = "DDR4";

            myPCBox.MyProcessor ++;
            myPCBox.MyProcessorName = "Intel";

            myPCBox.MyHardDrive ++;
            myPCBox.MyHardDriveName = "Seagate";

            myPCBox.MyPowerSupply ++;
            myPCBox.MyPowerSupplyName = "1000W";

            myPCBox.MyBox ++;
            myPCBox.MyBoxName = "Red";

            myPCBox.MyVideocard ++;
            myPCBox.MyVideoCardName = "RTX 4090";

            myPCBox.MyCDRom ++;
            myPCBox.MyCDRomName = "NEC";

            myPCBox.MyFlashCard ++;
            myPCBox.MyFlashCardName = "Orange";

            // Check Quantity

            if (myPC.MyMonitor == 0 || myPC.MyKeyboard == 0 || myPC.MyMouse == 0
                || myPCBox.MyMotherboard == 0 || myPCBox.MyMemory == 0 || myPCBox.MyProcessor == 0
                || myPCBox.MyHardDrive == 0 || myPCBox.MyPowerSupply == 0 || myPCBox.MyBox == 0
                || myPCBox.MyVideocard == 0 || myPCBox.MyCDRom == 0 || myPCBox.MyFlashCard == 0 )
            {
                myPC.WrongQuantity();
            }                
            
            
            int quantity = 0;
            Console.Write("Введите количество рабочих мест: ");
            quantity = int.Parse(Console.ReadLine());

            myPC[] myParkOfPCs = new myPC[quantity];
            BuildMyPCBox[] myParkOfPCs_PCBox = new BuildMyPCBox[quantity];

            void fillMyPark()
            {
                for (int i = 0; i < quantity; i++)
                {
                    myParkOfPCs[i] = new myPC();
                    myParkOfPCs[i].PCQuantity++;

                    myParkOfPCs[i].MyMonitor++;
                    myParkOfPCs[i].MyMonitorName = "LG";

                    myParkOfPCs[i].MyKeyboard++;
                    myParkOfPCs[i].MyKeyboardName = "A4";

                    myParkOfPCs[i].MyMouse++;
                    myParkOfPCs[i].MyMouseName = "SteelSeries";

                    myParkOfPCs_PCBox[i] = new BuildMyPCBox();

                    myParkOfPCs_PCBox[i].MyMotherboard++;
                    myParkOfPCs_PCBox[i].MyMotherboardName = "ASRock";

                    myParkOfPCs_PCBox[i].MyMemory++;
                    myParkOfPCs_PCBox[i].MyMemoryName = "DDR4";

                    myParkOfPCs_PCBox[i].MyProcessor++;
                    myParkOfPCs_PCBox[i].MyProcessorName = "Intel";

                    myParkOfPCs_PCBox[i].MyHardDrive++;
                    myParkOfPCs_PCBox[i].MyHardDriveName = "Seagate";

                    myParkOfPCs_PCBox[i].MyPowerSupply++;
                    myParkOfPCs_PCBox[i].MyPowerSupplyName = "1000W";

                    myParkOfPCs_PCBox[i].MyBox++;
                    myParkOfPCs_PCBox[i].MyBoxName = "Red";

                    myParkOfPCs_PCBox[i].MyVideocard++;
                    myParkOfPCs_PCBox[i].MyVideoCardName = "RTX 4090";

                    myParkOfPCs_PCBox[i].MyCDRom++;
                    myParkOfPCs_PCBox[i].MyCDRomName = "NEC";

                    myParkOfPCs_PCBox[i].MyFlashCard++;
                    myParkOfPCs_PCBox[i].MyFlashCardName = "Orange";
                }


            }
            fillMyPark();

            // All List of spare parts
            Console.WriteLine($"Рабочих мест создано: {quantity}");
            int choise = 0;
            while (choise != 4)
            {
                Console.WriteLine();
                Console.WriteLine("1. Вывести список");
                Console.WriteLine("2. Поменять комплектующие");
                Console.WriteLine("3. Записать в файл");
                Console.WriteLine("4. Выход");

                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {

                    case 1:

                        void showAll()
                        {
                            for (int i = 0; i < quantity; i++)
                            {

                                Console.WriteLine();
                                Console.WriteLine($"Рабочее место {myParkOfPCs[i].PCQuantity} создано: ");
                                Console.WriteLine($"1. Монитор: {myParkOfPCs[i].MyMonitorName}");
                                Console.WriteLine($"2. Клавиатура: {myParkOfPCs[i].MyKeyboardName}");
                                Console.WriteLine($"3. Мышь: {myParkOfPCs[i].MyMouseName}");
                                Console.WriteLine($"4. Материнская плата: {myParkOfPCs_PCBox[i].MyMotherboardName}");
                                Console.WriteLine($"5. Память: {myParkOfPCs_PCBox[i].MyMemoryName}");
                                Console.WriteLine($"6. Процессор: {myParkOfPCs_PCBox[i].MyProcessorName}");
                                Console.WriteLine($"7. Жесткий диск: {myParkOfPCs_PCBox[i].MyHardDriveName}");
                                Console.WriteLine($"8. Блок питания: {myParkOfPCs_PCBox[i].MyPowerSupplyName}");
                                Console.WriteLine($"9. Корпус: {myParkOfPCs_PCBox[i].MyBoxName}");
                                Console.WriteLine($"10. Видеокарта: {myParkOfPCs_PCBox[i].MyVideoCardName}");
                                Console.WriteLine($"11. CD-Rom: {myParkOfPCs_PCBox[i].MyCDRomName}");
                                Console.WriteLine($"12. Флеш-карта: {myParkOfPCs_PCBox[i].MyFlashCardName}");
                            }
                        }


                        showAll();
                        break;

                    case 2:
                        // Change Spare Parts

                        Console.Write("Введите номер компьютера: ");
                        int PCChoise = int.Parse(Console.ReadLine());
                        Console.Write("Введите номер запасной части для замены: ");
                        int choise2 = int.Parse(Console.ReadLine());
                        switch (choise2)
                        {
                            case 1:
                                Console.Write("Новое название монитора: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs[PCChoise - 1].MyMonitorName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 2:
                                Console.Write("Новое название клавиатуры: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs[PCChoise - 1].MyKeyboardName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 3:
                                Console.Write("Новое название мышки: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs[PCChoise - 1].MyMouseName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 4:
                                Console.Write("Новое название клавиатуры: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyMotherboardName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 5:
                                Console.Write("Новое название памяти: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyMemoryName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 6:

                                Console.Write("Новое название процессора: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyProcessorName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 7:
                                Console.Write("Новое название жесткого диска: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyHardDriveName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 8:
                                Console.Write("Новое название БП: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyPowerSupplyName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 9:
                                Console.Write("Новое название корпуса: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyBoxName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 10:
                                Console.Write("Новое название видеокарты: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyVideoCardName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 11:
                                Console.Write("Новое название CD-Roma: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyCDRomName = Console.ReadLine();
                                }
                                showAll();
                                break;
                            case 12:
                                Console.Write("Новое название флеш-карты: ");
                                if (quantity > 0)
                                {
                                    myParkOfPCs_PCBox[PCChoise - 1].MyFlashCardName = Console.ReadLine();
                                }
                                showAll();
                                break;
                        }
                        break;
                    case 3:

                        Console.Write("Введите номер компьютера для записи: ");
                        int PCChoise2 = int.Parse(Console.ReadLine());

                        string myText = "Монитор: " + myParkOfPCs[PCChoise2 - 1].MyMonitorName + "\n" + 
                            "Клавиатура: " + myParkOfPCs[PCChoise2 - 1].MyKeyboardName + "\n" +
                            "Мышка: " + myParkOfPCs[PCChoise2 - 1].MyMouseName + "\n" + 
                            "Материнка: " + myParkOfPCs_PCBox[PCChoise2 - 1].MyMotherboardName + "\n" +
                            "Память: "  + myParkOfPCs_PCBox[PCChoise2 - 1].MyMemoryName + "\n" + 
                            "Процессор:" + myParkOfPCs_PCBox[PCChoise2 - 1].MyProcessorName +
                            "Жесткий диск: " + myParkOfPCs_PCBox[PCChoise2 - 1].MyHardDriveName + "\n" + 
                            "БП: " + myParkOfPCs_PCBox[PCChoise2 - 1].MyPowerSupplyName + "\n" +
                            "Корпус" + myParkOfPCs_PCBox[PCChoise2 - 1].MyBoxName + "\n" + 
                            "Видеокарта: " + myParkOfPCs_PCBox[PCChoise2 - 1].MyVideoCardName + "\n" +
                            "CD-Rom: " + myParkOfPCs_PCBox[PCChoise2 - 1].MyCDRomName + "\n" + 
                            "Флешка: " + myParkOfPCs_PCBox[PCChoise2 - 1].MyFlashCardName;

                        File.WriteAllText("test.txt", myText);

                        Console.WriteLine("Записано");

                        break;
                    case 4:
                    break;
                    default:
                    
                    break;
                }

                


                //Console.ReadKey();
            }
        }
    }
}
