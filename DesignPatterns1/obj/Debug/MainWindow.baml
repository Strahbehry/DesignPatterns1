   M S B A M L   `   `   `  ����J  FDesignPatterns1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DesignPatterns1DesignPatterns1  5   	        DesignPatterns1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DesignPatterns1     5   	     � Title$  DesignPatterns1��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��259* �6   �� 5      $
��533* �6   .+�5   
   �� -   5         ��Name$ CircuitList��5      $
��Left=�6(   $��	10,10,0,0q�6C   $	��Top=�6V   $	��120��6n   6z   �� 5   
   -   5         ��Name$ showCircuitBtn��5      $��Go��6)   $
��Left=�66   $��
135,10,0,0q�6Q   $	��Top=�6e   $��37��6}   6�   �� 5   
   -   5        $ helpBtn��5      $��Hide/Show help��6"   $
��Left=�6;   $	��Top=�6V   $	��108��6n   $��415.31,10,0,0q�6z   $��1��6�   7  1System.Windows.Forms.Integration.WindowsFormsHost  5   
   -   5          Name$ 	graphForm��5      $
��Left=�6.   $	��372��6I   $��	10,37,0,0q�6V   $	��Top=�6i   $	��772��6�   $��2��6�   5      5      