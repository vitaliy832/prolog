
// Learn more about F# at https://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open System.Drawing
open System.IO
open System.Windows.Forms

let form = new Form(Width= 400, Height = 300, Text = "F#  Главная форма", 
    Menu = new MainMenu())

// Меню бар 

let mFile = form.Menu.MenuItems.Add("&Файл")
let mForms = form.Menu.MenuItems.Add("&Формы") 
let mHelp = form.Menu.MenuItems.Add("&Помощь") 
// Подменю
let miMessage = new MenuItem("&Пример сообщения")
let miSeparator = new MenuItem("-") 
let miExit = new MenuItem("&Exit") 
let miAbout = new MenuItem("&О программе...") 
let miForm1 = new MenuItem("&Форма_1")
let miForm2 = new MenuItem("&Форма_2") 
let miForm3 = new MenuItem("&Форма_3")

// Добавление подменю в пункты меню   

mFile.MenuItems.Add(miMessage)
mFile.MenuItems.Add(miSeparator)
mFile.MenuItems.Add(miExit)
mHelp.MenuItems.Add(miAbout)
mForms.MenuItems.Add(miForm1)
mForms.MenuItems.Add(miForm2)
mForms.MenuItems.Add(miForm3)

// Создаем картинки и задаем им свойства
let image1 = new PictureBox(SizeMode = PictureBoxSizeMode.AutoSize, Top = 5)
let image2 = new PictureBox(SizeMode = PictureBoxSizeMode.AutoSize, Top = 5 , Left =133)
let image3 = new PictureBox(SizeMode = PictureBoxSizeMode.AutoSize, Top = 5, Left = 266)
// Указываем местоположение картинок
image1.ImageLocation <-"1.PNG"
image2.ImageLocation <-"2.PNG"
image3.ImageLocation <-"3.PNG"
// Добавляем картинки на форму
form.Controls.Add(image1)
form.Controls.Add(image2)
form.Controls.Add(image3) 
// Создаём и добавляем надпись на форму
let  Label1  =  new  Label(Text="Пример  вывода  изображений  на  экран", Top=150)
Label1.Width <-form.Width
Label1.Left <-80
form.Controls.Add(Label1)
// Запускаем форму
do Application.Run(form)

// Создание сообщения
let  Msg   _ =   MessageBox.Show("&Пример сообщения в F#!", "&Сообщение") |> ignore    

// Событие на нажатие пункта меню
let  _ = miMessage.Click.Add(Msg) 

// Закрытие приложения
let Exit _ = form.Close()
let _ = miExit.Click.Add(Exit)

//Форма_1 
let Form1 = new Form(Text = "Дочерняя форма No1" ,Width = 400, Height = 300)
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
0