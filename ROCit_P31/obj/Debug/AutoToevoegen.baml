   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5          ROCit_P31.AutoToevoegen   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��Auto's Toevoegen��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   $��Trebuchet MS)�6q   
�������6�   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  dgAutos��5      $��222,10,10,10q�6$      AutoGenerateColumns .  $��Trebuchet MS)�6V      CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Merk��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *merk+   ClipboardContentBinding 6>   Z� 6a     5      $ Kleur��6b    6%   �� *kleur+ 6?   Z� 6b     5      $ Kenteken��6e    6%   �� *
kenteken+ 6B   Z� 6e     5      $ 	Personeel��6k    6%   �� *personeel.naam+ 6H   Z� 6k     5      $ Dealer��6n    6%   �� *dealer.dealerNaam+ 6K   Z� 6n     5      $ Onderhoudsbeurten��6h    6%   �� *onderhoudId+ 6E   Z� 6h   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Update��6)      CellTemplate 5      �� 5      .R�5      �� .+�5   "   ��  ��Name$ 	btnUpdate��6)   -   5        $	��✏��5   <   6H   5      5      5        5      $ Delete��6)    5      �� 5      .R�5      �� .+�5    "   �� $ 	btnDelete��6)   -   5        $
��🗑��5    <   6I   5!      5"      5$      5&      �� 5'   
   $
��Merk��6   $
��Left=�6   $��	10,39,0,0q�6:   $	��Top=�6M   	 J� RenderTransformOrigin$	 -2.866,0.262&�6e   $��Trebuchet MS)�6�   
�������6�   �� 5(   
   $��Kleur��6   $
��Left=�6    $��	10,70,0,0q�6;   $	��Top=�6N   $	 0.873,-4.386&�6f   $��Trebuchet MS)�6�   
�������6�   �� 5)   
   $��Kenteken��6   $
��Left=�6#   $��	10,98,0,0q�6>   $	��Top=�6Q   $��Trebuchet MS)�6i   
�������6�   �� 5*   
   -   5        
 ��Name$
 tbxMerk��5*      $
��Left=�6#   $��23��6>   $��	84,41,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5+   
   -   5        $
 tbxKleur��5+      $
��Left=�6$   $��23��6?   $��	84,72,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5,   
   -   5        $
 tbxKenteken��5,      $
��Left=�6'   $��23��6B   $��
84,100,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5-   
   -   5        $ 
btnOpslaan��5-      $��Opslaan��6%   $
��Left=�67   $��129,184,0,0q�6R   $	��Top=�6g   $��75��6   $��Trebuchet MS)�6�   
����������	#FFFF8900
�������$��3q�6�   �� 5.   
   -   5         ��Name$ cbxPersoneel��5.      $
��Left=�6)   $��
84,128,0,0q�6D   $	��Top=�6X   $	��120��6p    �� DisplayMemberPath$
 naam��6|    �� SelectedValuePath$ personeelId��6�   �� 5/   
   $��	Personeel��6   $
��Left=�6$   $��
10,126,0,0q�6?   $	��Top=�6S   $��Trebuchet MS)�6k   
�������6�   �� 50   
   $��Dealer��6   $
��Left=�6!   $��
10,155,0,0q�6<   $	��Top=�6P   $��Trebuchet MS)�6h   
�������6�   �� 51   
   -	   5        $ 	cbxDealer��51      $
��Left=�6&   $��
84,157,0,0q�6A   $	��Top=�6U   $	��120��6m   $ 
dealerNaam��6y   $ dealerId��6�   54      55      