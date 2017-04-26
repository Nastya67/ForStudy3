using System;
using SFML.Graphics;
using SFML.Window;
using CorseWork;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SFML_Test
{
    static class Program
    {
        static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        } 

        static void choseTree(RenderWindow app)
        {
            Texture t = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\sklad.jpg");
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
        static void shopGame(RenderWindow app)
        {
            Texture t = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\sklad.jpg");
            Sprite s = new Sprite(t);
            Font font = new Font("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\To The Point.ttf");
            int size = Shop.Asortiment.Count;
            Texture[] tfon = new Texture[size];
            Sprite [] fon = new Sprite[size];
            Sprite [] trees = new Sprite[size];
            Text [] names = new Text[size];
            List<string> keys = new List<string>();
            foreach (string gc in Shop.Asortiment.Keys)
                keys.Add(gc);
            Color colorFon = new Color(255, 255, 255, 150);
            for(int i = 0; i < size; i++)
            {
                tfon[i] = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\"+keys[i]+".jpg");
                trees[i] = new Sprite(tfon[i]);
                fon[i] = new Sprite();
                fon[i].Color = colorFon;
                fon[i].TextureRect = new IntRect(new SFML.System.Vector2i(10+250*i, 10+300*(i%2)), new SFML.System.Vector2i(250, 300));
                names[i] = new Text(keys[i], font, 14);
                names[i].Position = new SFML.System.Vector2f(10 + 250 * i, 300 + 300 * (i % 2));
            }

            
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
        static void newGame (RenderWindow app)
        {
            Texture t = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\fon.jpg");
            Sprite s = new Sprite(t);

            Texture [] tTree = { new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\treeButton.jpg"),
            new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\shopButton.jpg")};
            Sprite [] bottons = new Sprite[tTree.Length];
            for (int i = 0; i < bottons.Length; i++)
            {
                bottons[i] = new Sprite(tTree[i]);
                bottons[i].Position = new SFML.System.Vector2f(1200, 150 + i*70);
                bottons[i].Scale = new SFML.System.Vector2f((float)0.1, (float)0.1);
            }

            RectangleShape button = new RectangleShape(new SFML.System.Vector2f(50, 60));
            button.FillColor = new Color(200, 200, 20, 150);
            RectangleShape r = new RectangleShape(new SFML.System.Vector2f(50, 400));
            r.Position = new SFML.System.Vector2f(1200, 100);
            r.FillColor = new Color(255, 255, 255, 150);


            Gardener gardener = Gardener.gardener("Name");
            gardener.garden = new Garden();

            while (app.IsOpen)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    app.Close();
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
                                    
                                    break;
                                case 1:
                                    shopGame(app);
                                    break;
                                
                            }
                        }
                    }
                }
                app.Clear();
                app.DispatchEvents();
                app.Draw(s);
                app.Draw(r);
                app.Draw(button);
                for (int i = 0; i < bottons.Length; i++)
                    app.Draw(bottons[i]);
                app.Display();
                button.Position = new SFML.System.Vector2f(-100, -100);
            }
        } 
        static void loadGame(RenderWindow app)
        {
            Texture t = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\fon.jpg");
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
        static void showStatistics(RenderWindow app)
        {
            Texture t = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\fon.jpg");
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
            RenderWindow app = new RenderWindow(new VideoMode(1280, 720), "Garden", Styles.Fullscreen);
            app.Closed += new EventHandler(OnClose);

            Color green = new Color(100, 100, 255);
            Color blue = new Color(5, 5, 200);
            RectangleShape r = new RectangleShape(new SFML.System.Vector2f(400, 530));
            r.Position = new SFML.System.Vector2f(450, 100);
            r.FillColor = new Color(255, 255, 255, 150);

            Texture t = new Texture("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\fon2.jpg");
            Sprite s = new Sprite(t);

            Font font = new Font("D:\\Nastya\\CurStudy\\OOP\\CorseWork\\GoodDog.otf");
            Text head = new Text("Menu", font, 100);
            head.Color = blue;
            head.Position = new SFML.System.Vector2f(530, 80);
            string[] textMenu = {"New Game", "Load Game", "Statistics", "Exit"};
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