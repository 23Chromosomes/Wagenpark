   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5          ROCit_P31.DealerOpvagenUC   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��Dealer Opvragen��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $��Trebuchet MS)�6p   
�������6�   �� 5   
   $��Dealernaam:��6   $
��Left=�6&   $��	26,65,0,0q�6A   $	��Top=�6T   $��Trebuchet MS)�6l   
�������  J� RenderTransformOrigin$  0.327,0.567&�6�   �� 5   
   -   5         ��Name$ txtDealerNaam��5      $
��Left=�6)   $��23��6D   $��
109,65,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   $  0.502,1.357&�6�   �� 5   
   -   5         ��Name$ btnZoek��5      $
��Zoek��6"   $
��Left=�61   $��154,112,0,0q�6L   $	��Top=�6a   $��75��6y   $��Trebuchet MS)�6�   
����������	#FFFF8900
�������$��3q�6�   �� 5   
   -   5         ��Name$ dealerLijst��5      $
��Left=�6'   $	��153��6B   $��
10,166,0,0q�6O   $	��Top=�6c   $	��325��6{   $��Trebuchet MS)�6�   �� 5   
   $��Dealer Gegevens��6   $
��Left=�6*   $��
10,135,0,0q�6E   $	��Top=�6Y   $��Trebuchet MS)�6q   
�������6�   �� 5   
   $��Dealernummer:��6   $
��Left=�6(   $��	10,37,0,0q�6C   $	��Top=�6V   $��Trebuchet MS)�6n   
�������6�   �� 5   
   -   5        $ txtDealerNummer��5      $
��Left=�6+   $��23��6F   $��
109,37,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dealerDG��5      $
��Left=�6%   $	��153��6@   $��412,166,0,0q�6M   $	��Top=�6b   $	��333��6z      AutoGenerateColumns .  $��Trebuchet MS)�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Dealernummer��6e   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *
dealerId+
   ClipboardContentBinding
 6B   Z� 6e     5      $ 
Dealernaam��6g   	 6%   �� *
dealerNaam+
 6D   Z� 6g   5      �� 5   
   $��Dealer Grid:��6   $
��Left=�6'   $��412,135,0,0q�6B   $	��Top=�6W   $��Trebuchet MS)�6o   
�������6�   5      5      