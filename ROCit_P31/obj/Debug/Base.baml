   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5   	       ROCit_P31.Base   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ROCit_P31     5   	     � Title$
  Base��5   	   $	��600��6   $
��1000��6#   .��5	      � .+�5
   
   ��  �� CornerRadius$ 5��6   
����������	#FF0043FF$��2q�6L   $	��Top=�6`   ._�5      �� $
��Left=�6   $	��372��64   $��10.4,38.4,0,0q�6A   $	��Top=�6X   $	��242��6p   .+�5      �� -   5         ��Name$ btnOverzicht��5      $��Overzicht Lease auto's��6/   $��41��6P   $��
0,0,-0.4,0q�6\   ���	#FFFF8900
������� J� OpacityMask
 �����
�������$��3q�6�   �� 5      -   5        $ btnleasetoevoegen��5      $��Lease auto toevoegen��64   $��41��6S   $��
0,0,-0.4,0q�6_   ���	#FFFF8900
�������
�������$��3q�6�   �� 5      -   5        $ 	btnkosten��5      $��Kosten��6,   $��41��6=   $��
0,0,-0.4,0q�6I   ���	#FFFF8900
�������
�������$��3q�6�   �� 5      -   5        $ btnOnderhoudToevoegen��5      $��Onderhoudsbeurt Toevoegen��68   $��41��6\   $��
0,0,-0.4,0q�6h   ���	#FFFF8900
�������
�������$��3q�6�   �� 5      -   5        $ btnPersoneel��5      $��	Personeel��6/   $��41��6C   $��
0,0,-0.4,0q�6O   ���	#FFFF8900
�������
�������$��3q�6�   �� 5      -   5        $ btnDealerZoeken��5      $��Dealer Opvragen��62   $��41��6L   ���	#FFFF8900
�������
�������$��3q�6�   �� 5      -   5        $ btnDealerToevoegen��5      $��Dealer Toevoegen��65   $��41��6P   ���	#FFFF8900
�������
�������$��3q�6�   �� 5      -   5        $ btnWerkplaatsToevoegen��5      $��Werkplaats Toevoegen��69   $��41��6X   ���	#FFFF8900
�������
�������$��3q�6�   5      5       � 5   
   -	   5          �Name$ 	mainframe��5      $��Frame��6#   $��257,41,9.6,51.4q�63    J� RenderTransformOrigin$ 0.338,0.357&�6L     � NavigationUIVisibility$ Hidden=�6p   �� 5   
   -
   5        $ btnUitloggen��5      $��	Uitloggen��6'   $
��Left=�6;   $��
10,519,0,0q�6V   $	��Top=�6j   $	��242��6�   $��41��6�   ���	#FFFF8900
�������
�������$��3q�6�   �� 5   
   -   5         ��Name$ stack��5   .    �� Orientation$ 
Horizontal=�6   $��41��6=   $	��Top=�6I   $��	0,0,9.6,0q�6a   	 � 	Resources	 5      !   ROCit_P31.NegatingConverter   NegatingConverter 	 slide
 W� From g� Duration �� TargetProperty �� 
TargetName g� RepeatBehavior	 W� To �� ElementName��%�   &	        &	        5      6*   �� 5      .��5      W� $
 0X�6&   $ 00:00:10D�6X   $ X�5      $ transferCurreny��5      $ Forever��5        5   /   �� *Width+$ canvas��5       5!      5"      z�5#      T� 5$      -   5        transferCurreny�� T� X$ 0Q�5$   >    � Triggers 5&      :� 5'       :� RoutedEvent$ StackPanel.Loaded��6   .[�5(      �� #��[ 6&   5)      :� 5*      $ StackPanel.SizeChanged��6   .[�5+      �� #��[ 6&   5,      .+�5.      �� -   5         ��Name$ canvas��5.      ��6%   �� *ActualWidth+$ stack��.+�5/      �� -   5         ��Name$ txtKron��5/   @   $��StackOverflow��6   $��25(�61    �� Left$ 0��6Q   �� 50      $��25(�6G   ��6   �� *Text+$ txtKron�� 6U   �� *Width+$ canvas�� �� 	Converter# [  52      53      �� 54   
   $ 10��6   $��10,6,9.6,501.4q�6%   
 �� Top$ 10��6=   $	��974��6M   $ 0.5,0.5&�6Y   
�������z�55      V� 56      .~�57      �� �� 58       �� AngleX$ 0.754Q�6$   �� 59      T� 5:      $
 0.52Q�6)   5;      5=      5>      5?      