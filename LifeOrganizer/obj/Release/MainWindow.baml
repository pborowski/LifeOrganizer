   M S B A M L   `   `   `  ����   LifeOrganizer    LifeOrganizer.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  LifeOrganizer��$	��600��$	��850��.����  �� TabStripPlacement$
 Left=�$��14(�.@��� -   $��TabItem_Tasks��$��Zadania��.��� -   $��Grid_Task_Window�� � ShowGridLines .  � ColumnDefinitions �� �� $��50 ��� �� $��50 ��� �� $��50 ��� $��80 � � RowDefinitions �� $
��Auto ��� $
��Auto �.+��� -   $��Label_To_Do��$��20(�$��0��$��0��$��2��.��To Do�� -   $��Doing��$��20(�$��0��$��2��$��2��.��Doing�� -   $
��Done��$��20(�$��0��$��4��$��2��.��Done�� -   $��ScrollViever_ToDo��$��0��$��1��$
��Auto=�$��0,0,0,5q�.���� -   $��StackPanel_To_Do���� -	   $��ScrollViever_Doing��$��2��$��1��$
��Auto=�$��0,0,0,5q�.���� -
   $��StackPanel_Doing���� -   $��ScrollViever_Done��$��4��$��1��$
��Auto=�$��0,0,0,5q�.���� -   $��StackPanel_Done���� -   $��StackPanel_Menu��$��6��$��1��.+��� -   $��
Button_Add��$��5q�$��5q�$��16(� �� 	IsDefault . .��Dodaj�� -   $��TabItem_Calendar��$��	Kalendarz��.��&   System.Windows.Controls.Calendar     DisplayMode$ Month=�$��Center=�$��Center=�