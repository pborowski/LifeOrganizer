   M S B A M L   `   `   `  ����  LifeOrganizer$    LifeOrganizer.Edit_Task_Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Edit_Task_Window��5   	   $	��300��6"   $	��300��6/   .��5      ]� .+�5   
   �� $��20(�6   $
��Left=�6   $	��Top=�69   .��6O   Nazwa:6W   �� 5   
   -   5        $��Textbox_Add_Title��5      $
��Auto��6+   $	��Top=�6:   6Q   � 5   
   $	��Top=�6    � RowDefinitions 5	      �� 5
      6"    � ColumnDefinitions 5      �� 5      $
��auto �6#   62   �� 5      6%   .+�5      �� $��20(�6   $��0��6#   $
��Left=�63   $	��Top=�6N   .��6d   
Deadline6n   (  "System.Windows.Controls.DatePicker  5      -   5        $��DatePicker_Add_Date��5      $
��Left=�64   $��1��6O   $�� 5q�6_   6n   5      �� 5   
   $��20(�6   $
��Left=�6   $
��Auto��69   $	��Top=�6G   .��6]   Opis:6d   �� 5   
   -   5        $��Textbox_Add_Description��5      $��70��62   $	��Top=�6>    �� TextWrapping$
 Wrap=�6S   6i   �� 5   
   -   5        $��Button_Add_Task_Confirm��5      $��30��6W   $��80��6c   $��Bottom=�6n   $��12(�6�   $��Right=�6�   $��10q�6�   $��5q�6�    �� 	IsDefault . .��6�   Dodaj6�   5      5      