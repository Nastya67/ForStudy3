using System;
using SFML.Graphics;
using SFML.Window;
using CorseWork;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SFML_Test
{
    static class Program
    {
        public static string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
        static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            
            window.Close();
        } 
        static GardenComponent shopGame(RenderWindow app)
        {
            Console.WriteLine("Shop");
            GardenComponent toReturn = null;
            int exit = 0;
            Texture t = new Texture(rootFolder+"sklad.jpg");
            Sprite s = new Sprite(t);
            Font font = new Font(rootFolder+"To The Point.ttf");
            int size = Shop.Asortiment.Count;
            Texture[] tfon = new Texture[size];
            RectangleShape[] fon = new RectangleShape[size];
            Sprite [] trees = new Sprite[size];
            Text [] names = new Text[size];
            List<string> keys = new List<string>();
            foreach (string gc in Shop.Asortiment.Keys)
                keys.Add(gc);
            Color colorFon = new Color(255, 255, 255, 100);
            int y1 = 10;
            int y2 = 350;
            Gardener gardener = Gardener.gardener();
            for(int i = 0; i < size; i++)
            {
                tfon[i] = new Texture(rootFolder+"tree"+i.ToString()+".png");
                trees[i] = new Sprite(tfon[i]);
                trees[i].Scale = new SFML.System.Vector2f((float)0.6, (float)0.6);
                fon[i] = new RectangleShape(new SFML.System.Vector2f(230, 300));
                fon[i].FillColor = colorFon;
                names[i] = new Text(keys[i], font, 45);
                if (i<(size/2))
                {
                    trees[i].Position = new SFML.System.Vector2f(10+50 + 255 * i, y1+20);
                    names[i].Position = new SFML.System.Vector2f(40 + 255 * i, 230);
                    fon[i].Position = new SFML.System.Vector2f(10 + 255 * i, y1);
                }
                else
                {
                    trees[i].Position = new SFML.System.Vector2f(10+50 + 255 * (i-size/2), y2+20);
                    names[i].Position = new SFML.System.Vector2f(40 + 255 * (i-size/2), y2+220);
                    fon[i].Position = new SFML.System.Vector2f(10 + 255 *( i-size/2), y2);

                }
                names[i].Color = Color.Black;
            }

            
            while (app.IsOpen && exit != 1)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    app.Close();
                }
                for (int i = 0; i < size; i++)
                    if (Mouse.GetPosition().X > fon[i].Position.X &&
                        Mouse.GetPosition().X < (fon[i].Position.X + fon[i].GetLocalBounds().Width) &&
                        Mouse.GetPosition().Y > fon[i].Position.Y &&
                        Mouse.GetPosition().Y < (fon[i].Position.Y + fon[i].GetLocalBounds().Height))
                    {
                        fon[i].FillColor = new Color(100, 100, 250, 200);
                        if (Mouse.IsButtonPressed(Mouse.Button.Left))
                        {
                            toReturn = gardener.bought(i);
                            exit = 1;
                        }

                    }
                app.Clear();
                app.DispatchEvents();
                app.Draw(s);
                for(int i = 0; i < size; i++)
                {
                    app.Draw(fon[i]);
                    app.Draw(trees[i]);
                    app.Draw(names[i]);
                }   
                app.Display();
                for(int i = 0; i < size; i++)
                {
                    fon[i].FillColor = colorFon;
                }
            }
            Console.WriteLine("Shop exit");
            return toReturn;
        }
        static void newGame (RenderWindow app)
        {
            Console.WriteLine("Game");
            Texture t = new Texture(rootFolder+"fon.jpg");
            Sprite s = new Sprite(t);

            Texture [] tTree = { new Texture(rootFolder+"button1.png"),
            new Texture(rootFolder+"shopButton.jpg"),
            new Texture(rootFolder+"button3.png")};
            Sprite [] bottons = new Sprite[tTree.Length];
            for (int i = 0; i < bottons.Length; i++)
            {
                bottons[i] = new Sprite(tTree[i]);
                bottons[i].Position = new SFML.System.Vector2f(1300, 150 + i*70);
                bottons[i].Scale = new SFML.System.Vector2f((float)0.1, (float)0.1);
            }

            RectangleShape button = new RectangleShape(new SFML.System.Vector2f(50, 60));
            button.FillColor = new Color(200, 200, 20, 150);
            RectangleShape r = new RectangleShape(new SFML.System.Vector2f(50, 400));
            r.Position = new SFML.System.Vector2f(1300, 100);
            r.FillColor = new Color(255, 255, 255, 150);
            Font font = new Font(rootFolder+ "Pat-PaCool.otf");
            string [] pre = { "Collected fruit: ", "Fallen fruit: " };
            Text fruits = new Text("Collected fruit: 0", font, 40);
            Text fallenFruit = new Text("Fallen fruit: 0", font, 40);
            SFML.System.Vector2f posText2 = new SFML.System.Vector2f(0, 60);
            Gardener gardener = Gardener.gardener();
            gardener.garden = new Garden();
            GardenComponent mouse = null;
            while (app.IsOpen)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    app.Close();
                }
                if(mouse!=null && Mouse.IsButtonPressed(Mouse.Button.Right))
                {
                    Console.WriteLine("plant!");
                    gardener.AddNewElementToGarden(mouse);
                    mouse = null;
                }
                for (int i = 0; i < bottons.Length; i++)
                {
                    if (Mouse.GetPosition().X > bottons[i].Position.X &&
                        Mouse.GetPosition().X < (bottons[i].Position.X + bottons[i].GetLocalBounds().Width * 0.1) &&
                        Mouse.GetPosition().Y > bottons[i].Position.Y &&
                        Mouse.GetPosition().Y < (bottons[i].Position.Y + bottons[i].GetLocalBounds().Height * 0.1))
                    {
                        button.Position = bottons[i].Position;
                        if (Mouse.IsButtonPressed(Mouse.Button.Left))
                        {
                            switch (i)
                            {
                                case 0:
                                    gardener.killWarms();
                                    break;
                                case 1:
                                    mouse = shopGame(app);
                                    break;
                                case 2:
                                    gardener.getFruits();
                                    fruits = new Text(pre[0]+gardener.numGetFruit.ToString(), font, 40);
                                    
                                    break;
                            }
                        }
                    }
                }
                gardener.refreshGarden();
                app.Clear();
                app.DispatchEvents();
                
                app.Draw(s);
                if (mouse != null)
                {
                    mouse.sprite.Position = new SFML.System.Vector2f(Mouse.GetPosition().X - mouse.sprite.TextureRect.Width / 2, Mouse.GetPosition().Y - mouse.sprite.TextureRect.Height);
                    app.Draw(mouse.sprite);
                }
                else
                {
                    app.Draw(r);
                    
                    app.Draw(button);
                    for (int i = 0; i < bottons.Length; i++)
                        app.Draw(bottons[i]);
                    
                    button.Position = new SFML.System.Vector2f(-100, -100);
                }
                gardener.display(app);
                app.Draw(fruits);
                fallenFruit = new Text(pre[1] + gardener.getFallenFruit().ToString(), font, 40);
                fallenFruit.Position = posText2;
                app.Draw(fallenFruit);
                app.Display();
            }
            save(gardener);
            Console.WriteLine("Game exit");
        } 
        static void save(Gardener g)
        {
            using (var ms = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Console.WriteLine("CloneTree");
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, g);
                ms.Position = 0;
            }
        }
        static void loadGame(RenderWindow app)
        {
            Gardener gardener = Gardener.gardener();
            gardener.loadGarden();
            Texture t = new Texture(rootFolder + "fon.jpg");
            Sprite s = new Sprite(t);

            Texture[] tTree = { new Texture(rootFolder+"button1.png"),
            new Texture(rootFolder+"shopButton.jpg"),
            new Texture(rootFolder+"button3.png")};
            Sprite[] bottons = new Sprite[tTree.Length];
            for (int i = 0; i < bottons.Length; i++)
            {
                bottons[i] = new Sprite(tTree[i]);
                bottons[i].Position = new SFML.System.Vector2f(1300, 150 + i * 70);
                bottons[i].Scale = new SFML.System.Vector2f((float)0.1, (float)0.1);
            }

            RectangleShape button = new RectangleShape(new SFML.System.Vector2f(50, 60));
            button.FillColor = new Color(200, 200, 20, 150);
            RectangleShape r = new RectangleShape(new SFML.System.Vector2f(50, 400));
            r.Position = new SFML.System.Vector2f(1300, 100);
            r.FillColor = new Color(255, 255, 255, 150);
            Font font = new Font(rootFolder + "Pat-PaCool.otf");
            string pre = "Collected fruit: ";
            Text fruits = new Text("Collected fruit: 0", font, 40);
            GardenComponent mouse = null;
            while (app.IsOpen)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    app.Close();
                }
                if (mouse != null && Mouse.IsButtonPressed(Mouse.Button.Right))
                {
                    Console.WriteLine("plant!");
                    gardener.AddNewElementToGarden(mouse);
                    mouse = null;
                }
                for (int i = 0; i < bottons.Length; i++)
                {
                    if (Mouse.GetPosition().X > bottons[i].Position.X &&
                        Mouse.GetPosition().X < (bottons[i].Position.X + bottons[i].GetLocalBounds().Width * 0.1) &&
                        Mouse.GetPosition().Y > bottons[i].Position.Y &&
                        Mouse.GetPosition().Y < (bottons[i].Position.Y + bottons[i].GetLocalBounds().Height * 0.1))
                    {
                        button.Position = bottons[i].Position;
                        if (Mouse.IsButtonPressed(Mouse.Button.Left))
                        {
                            switch (i)
                            {
                                case 0:
                                    gardener.killWarms();
                                    break;
                                case 1:
                                    mouse = shopGame(app);
                                    break;
                                case 2:
                                    gardener.getFruits();
                                    fruits = new Text(pre + gardener.numGetFruit.ToString(), font, 40);
                                    break;
                            }
                        }
                    }
                }
                gardener.refreshGarden();
                app.Clear();
                app.DispatchEvents();

                app.Draw(s);
                if (mouse != null)
                {
                    mouse.sprite.Position = new SFML.System.Vector2f(Mouse.GetPosition().X - mouse.sprite.TextureRect.Width / 2, Mouse.GetPosition().Y - mouse.sprite.TextureRect.Height);
                    app.Draw(mouse.sprite);
                }
                else
                {
                    app.Draw(r);

                    app.Draw(button);
                    for (int i = 0; i < bottons.Length; i++)
                        app.Draw(bottons[i]);

                    button.Position = new SFML.System.Vector2f(-100, -100);
                }
                gardener.display(app);
                app.Draw(fruits);
                app.Display();
            }
            save(gardener);
        }
        static void showStatistics(RenderWindow app)
        {
            Texture t = new Texture(rootFolder+"fon.jpg");
            Sprite s = new Sprite(t);
            while (app.IsOpen)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    app.Close();
                }
                app.Clear();
                app.DispatchEvents();
                app.Draw(s);

                app.Display();

            }
        }
        static void Main()
        {
            RenderWindow app = new RenderWindow(new VideoMode(1366, 768), "Garden", Styles.Fullscreen);
            app.Closed += new EventHandler(OnClose);

            Color green = new Color(100, 100, 255);
            Color blue = new Color(5, 5, 200);
            RectangleShape r = new RectangleShape(new SFML.System.Vector2f(400, 530));
            r.Position = new SFML.System.Vector2f(450, 100);
            r.FillColor = new Color(255, 255, 255, 150);

            Texture t = new Texture(rootFolder+"fon2.jpg");
            Sprite s = new Sprite(t);

            Font font = new Font(rootFolder+"GoodDog.otf");
            Text head = new Text("Menu", font, 100);
            head.Color = blue;
            head.Position = new SFML.System.Vector2f(530, 80);
            string[] textMenu = {"New Game", "Exit" };//"Load Game", "Statistics", "Exit"};
            Text[] menu = new Text[textMenu.Length];
            for (int i = 0; i < menu.Length; i++)
            {
                menu[i] = new Text(textMenu[i], font, 80);
                menu[i].Color = green;
                menu[i].Position = new SFML.System.Vector2f(500, 180 + i*80);
            }
            
            while (app.IsOpen)
            {               
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    app.Close();
                }
                for (int i = 0; i < menu.Length; i++)
                    if (Mouse.GetPosition().X > menu[i].Position.X && 
                        Mouse.GetPosition().X < (menu[i].Position.X + menu[i].GetLocalBounds().Width) &&
                        Mouse.GetPosition().Y- menu[i].GetLocalBounds().Height/2 > menu[i].Position.Y &&
                        Mouse.GetPosition().Y < (menu[i].Position.Y + menu[i].GetLocalBounds().Height*1.5))
                    {
                        menu[i].Color = new Color(10, 100, 10);
                        if (Mouse.IsButtonPressed(Mouse.Button.Left))
                        {
                            switch(i){
                                case 0: newGame(app);
                                    break;
                                case 1: loadGame(app);
                                    break;
                                case 2: showStatistics(app);
                                    break;
                                case 3: app.Close();
                                    break;
                            }
                        }
                        
                    }

                app.Clear();
                app.DispatchEvents();
                app.Draw(s);
                app.Draw(r);
                app.Draw(head);
                for (int i = 0; i < menu.Length; i++)
                    app.Draw(menu[i]);
                app.Display();
                for (int i = 0; i < menu.Length; i++)
                    menu[i].Color = green;
            }
            //System.Data.DataTable c = new System.Data.DataTable("Users");
            /*SqlConnection c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Nastya\\CurStudy\\OOP\\CorseWork\\CorseWork\\CorseWork.mdf;Integrated Security=True");
            c.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users",c);
            //cmd.ExecuteScalar();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 Console.WriteLine("{1}{0}", reader.GetSqlValue(0).ToString(), reader.GetSqlValue(1).ToString());
            }
            reader.Close();
            c.Close();
            */
            //System.Data.DataRow dr = c.NewRow();
            //dr["idUser"] = 0;
            //dr["name"] = "Nastya";
            //c.Rows.Add(dr);
            //c.Columns.ToString();
            /*foreach(System.Data.DataColumn dc in c.Columns)
            {
                Console.WriteLine(dc.ColumnName);
            }*/
            //Console.WriteLine(c.Columns.ToString()); //c.Rows[0][0].ToString() +" "+ c.Rows[0][1]);
            
            Console.ReadKey();
        } 
    } 
}