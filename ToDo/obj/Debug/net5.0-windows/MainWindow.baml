   M S B A M L   `   `   `  ����?  ;ToDo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ToDoToDo  5   	       ToDo.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:ToDo     5   	     � Title$  
MainWindow��5   	   $	��380��6   $	��650��6)   .��5	      � .+�5
   
   �� -   5        $	��Add��5
      $
��Left=�6   $��38��6:   $��	30,30,0,0q�6F   $	��Top=�6Y   $	��129��6q   6}   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $��38��6=   $��	30,80,0,0q�6I   $	��Top=�6\   $	��129��6t   6�   �� 5   
   -   5        $
��Edit��5      $
��Left=�6    $��38��6;   $��
30,130,0,0q�6G   $	��Top=�6[   $	��129��6s   6   �� 5   
   -   5        $
��Save��5      $
��Left=�6    $��38��6;   $��
30,180,0,0q�6G   $	��Top=�6[   $	��129��6s   6   � 5   
   $��-10,-10,10,10q�6   .+�5      �� -   5        $��lvTasks��5   -   $��200,30,0,130q�6   $��1��6<    �� View 5      �� 5      .P�5      �� $
��Name��6)    �� Width$	 220��67    �� DisplayMemberBinding 6C   �� *Name+�� 5      $��Deadline��6)   $	 150��6;    6G   �� *
Deadline+ �� StringFormat$ 
dd-MM-yyyy���� 5      $��IsDone��6)   $ 70��69    6D   �� *IsDone+5      5      �� 5      $
��Left=�6   $��205,255,0,0q�63   $'��!Description of the selected task:��6H   $
��Bold"�6q   $
��Wrap=�6�   $	��Top=�6�   �� 5      -   5         ��Name$ Description��5      $
��Left=�6-   $��205,280,0,0q�6H   $
��Wrap=�6]   $	��Top=�6q   $��60��6�   $	��400��6�   5      5      5      