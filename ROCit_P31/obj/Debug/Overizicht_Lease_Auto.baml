   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5      %    ROCit_P31.Overizicht_Lease_Auto   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��	Overzicht��6   $
��Left=�6$   $	��Top=�6?   $��Trebuchet MS)�6W   
�������6q   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  dgAuto��5      $
��Left=�6#   $	��373��6>   $��	10,67,0,0q�6K   $	��Top=�6^   $	��336��6v      AutoGenerateColumns .  $��Trebuchet MS)�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Merk��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *merk+   ClipboardContentBinding 6>   Z� 6a     5      $ Kenteken��6e    6%   �� *
kenteken+ 6B   Z� 6e     5      $ Kleur��6b    6%   �� *kleur+ 6?   Z� 6b     5      $ 	Personeel��6k    6%   �� *personeel.naam+ 6H   Z� 6k     5      $ Personeelnummer��6v    6%   �� *personeel.personeelsnumer+ 6S   Z� 6v   5      �� 5   
   $��Auto Opzoeken��6   $
��Left=�6(   $��
410,38,0,0q�6C   $	��Top=�6W   $��Trebuchet MS)�6o   
�������6�   �� 5   
   $��	Kenteken:��6   $
��Left=�6$   $��
440,70,0,0q�6?   $	��Top=�6S   $��Trebuchet MS)�6k   
�������6�   �� 5   
   -   5         ��Name$ tbxKenteken��5      $
��Left=�6'   $��23��6B   $��
542,74,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5         ��Name$ btnZoek��5      $
��Zoek��6"   $
��Left=�61   $��587,116,0,0q�6L   $	��Top=�6a   $��75��6y   $��Trebuchet MS)�6�   
����������	#FFFF8900
�������$��3q�6�   �� 5   
   -   5        	 ��Name$	 listAuto��5      $
��Left=�6$   $	��279��6?   $��410,161,0,0q�6L   $	��Top=�6a   $	��280��6y   $��Trebuchet MS)�6�   5      5      