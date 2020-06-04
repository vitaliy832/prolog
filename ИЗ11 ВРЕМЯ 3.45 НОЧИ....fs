
// Learn more about F# at https://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open System.Drawing
open System.IO
open System.Windows.Forms

let form = new Form(Width= 364, Height = 285, Text = "в этой штуке ты можешь открыть самый лучший в мире калькулятор", 
    Menu = new MainMenu())

// Меню бар 

let mFile = form.Menu.MenuItems.Add("&выход из этой штуки")
let mForms = form.Menu.MenuItems.Add("&калькулятор")
// Подменю

let miExit = new MenuItem("&лол, еще один выход")

let open1 = new MenuItem("&Открыть")

// Добавление подменю в пункты меню   

mForms.MenuItems.Add(open1)
mFile.MenuItems.Add(miExit)

// Создаем картинки и задаем им свойства
let  image2 = new PictureBox(SizeMode = PictureBoxSizeMode.AutoSize, Top = 5) 
image2.ImageLocation <-"56.PNG"
form.Controls.Add(image2) 

let button = new Button(Text = "Открыть калькулятор", Width=100, Height=50)
button.Location <- new Point(125, 175)
let  image1 = new PictureBox(SizeMode = PictureBoxSizeMode.AutoSize, Top = 100, Left = 50)
form.Controls.Add(button)







//Форма_1 
let Form1 = new Form(Text = "самый лучший калькулятор" ,Width = 400, Height = 300)
Form1.Controls.Add(image1)
let opForm1 _ = do Form1.ShowDialog()
let _ = open1.Click.Add(opForm1)
let _ = button.Click.Add(opForm1)
let Edit1 = new TextBox(Text="10")
let Edit2 = new TextBox(Top=20, Text="5") 
let button1 = new Button(Text="+", Top=50, Width=25, Height=25)
let button2 = new Button(Text="-", Top=50, Left=30, Width=25, Height=25)
let button3 = new Button(Text="*", Top=50, Left=60, Width=25, Height=25)
let button4 = new Button(Text="/", Top=50, Left=90, Width=25, Height=25)
Form1.Controls.Add(Edit1)
Form1.Controls.Add(Edit2)
Form1.Controls.Add(button1)
Form1.Controls.Add(button2)
Form1.Controls.Add(button3)
Form1.Controls.Add(button4)
let Summ _ = MessageBox.Show(string(int(Edit1.Text)+ (int(Edit2.Text))), "Сум-ма") |>ignore
let Minus _ =  MessageBox.Show(string(int(Edit1.Text)-(int(Edit2.Text))), "Раз-ность") |>ignore
let Umnoj _ =  MessageBox.Show(string(int(Edit1.Text)  *  (int(Edit2.Text))), "Умножение") |>ignore
let  Del _ =   MessageBox.Show(string(int(Edit1.Text)/   (int(Edit2.Text))), "Деление") |>ignore
let _= button1.Click.Add(Summ)
let _= button2.Click.Add(Minus)
let _= button3.Click.Add(Umnoj)
let _= button4.Click.Add(Del)
// Закрытие приложения
let Exit _ = form.Close ()
let _ = miExit.Click.Add(Exit)
// Запускаем форму
do Application.Run(form)








