   M S B A M L   `   `   `  ����S  OExample_20_CustomCommand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Example_20_CustomCommandExample_20_CustomCommand  5   	   )    #Example_20_CustomCommand.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7self&clr-namespace:Example_20_CustomCommand     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ self:CustomCommands.Exit��5      6`   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m�  m� Command$ self:CustomCommands.Exit��6   5      5      �� 5   
   $��1��6   $��Center=�6"   $��Center=�6?   .+�5      �� $��self:CustomCommands.Exit��6   .��68   Exit6>   5      5      5      