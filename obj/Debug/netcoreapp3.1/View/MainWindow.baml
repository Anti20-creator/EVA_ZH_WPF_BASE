   M S B A M L   `   `   `  ����=  9ZH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ZHZH  5   	       ZH.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:ZH     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    J� InputBindings 5	      �� 5
   
   
 �� Key$ W��6    �� Command 6   �� *MoveUp+�� 5   
   $ A��6    6   �� *
MoveLeft+�� 5   
   $ S��6    6   �� *
MoveDown+�� 5   
   $ D��6    6   �� *	MoveRight+.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� $��0��6   .@�5      m� $��Fájl��6   .@�5      m� $��Új játék��6   �� 5      m� 5       $	��4x4��6>    m� Command 6   �� *StartGameSmall+6>   m� 5!      $	��6x6��6?    6   �� *StartGameMedium+6?   m� 5"      $	��8x8��6>    6   �� *StartGameLarge+6>   �� 5#      m� 5$      $��	Kilépés��6   5%      5'      �� 5*   
   $��1��6   ��6$   �� *Fields+��5,      �� 5-      .R�5/      A�  A� Rows 6"   �� *	BoardSize+ A� Columns 6=   �� *	BoardSize+50      ��52      �� 54      .R�55      �� $|�False��6    J� RenderTransformOrigin$ 0.5, 0.5&�6H   $��24(�6i   $
��Bold"�6w   ��6/   �� *Text+z�58      �� 59      	 �� ScaleX$	 1Q�6-   
 �� ScaleY$
 1Q�68   ��5;      �� 5=       �� 
TargetType" ��6$    �� Triggers 5>   "   �� 5@   &    �� Binding 62   �� *Type+ �� Value 06K   .a�5A   *   ��  �� Property � �� �� Value
 � ���6G   5B   '   �� 5C   &    62   �� *Type+ 16K   .a�5D   *   ��  � ��
 �����6G   5E   '   5G      5I      5J      ��5L      �� 5N      .�5O      ��  � �� 61   �� *X+�� 5P       � �� 64   �� *Y+5Q      5S      5U      5V      