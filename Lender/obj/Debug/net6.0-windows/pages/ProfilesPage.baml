   M S B A M L   `   `   `  ����A  =Lender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Lender.pagesLender.pages  5      %clr-namespace:Lender.UI	Lender.UI  5          Lender.pages.ProfilesPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Lender.pages     5      &uiclr-namespace:Lender.UI     5        N� Title$  Profiles Page��5
       � DataContext 5      ��  �� RelativeSource �� *Self+.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��AddProfileMessage��5      $��1��6.   $��1��6;   $��2��6K   .+�5      ��    
FancyLabel#��[  5        MatteLightBlueOpague#��[ 5      $��No Profiles Found��5       $��16(�5!      �� 5#      #��[  5$        	MossGreen#��[ 5%      $0��*Create a Profile using the Button Below...��5&      5(      �� 5*   
   $��0��5+      $��0��5,      $��4��5-      $��4��5.      $��Hidden=�5/      $��Disabled=�50      $��Center=�51      $��Center=�52      $��
15 15 0 15q�53      .��55      �  56      �� 57      �� 58      �� 59      �� 5:      .+�5=      �� $��1��6   $��2��6/   ��6C   �� *
Profiles+��5>      �� 5?      .R�5@      ��  �� CornerRadius$ 8��6%     Eggplant#��[ 66   $��Center=�6]    �� Padding$ 10q�6x   $��10q�6�   ._�5A   "   �  5B   &   �� 5C   *   �� 5D   *    5G   &   �� 5H   *   $
��0.4* �6;   �� 5I   *   �� 5J   *   $
��0.6* �6;   .+�5M   &   � $��2��6+   $��2��6<   $��Center=�6P    5N   *   �� 5O   .   �� 5P   .    5S   *   �� 5T   .   $
��0.4* �6?   �� 5U   .   .+�5X   *   �� $��0��60   $��0��6=   $��Loan Id:��6M   #��[  6`   $
��Left=�5Y   0   �� 5[   *   $��1��60   $��0��6=   $��Name:��6M   #��[  6]   $
��Left=�5\   0   �� 5^   *   $��0��60   $��1��6=   #��[  6h    	 Khaki#��[ 5_   0   $
��Left=�6T   ��5^   M   �� *LoanId+5_   T   �� 5a   *   $��1��60   $��1��6=   #��[  6n     MatteLightBlue#��[ 5b   0   $
��Left=�6]   ��5a   M   �� *BorrowerName+5b   ]   5c   '   �� 5e   &   -   5        $��1��5e   -   $��2��6:     FancyButton#��[ 5f   )     Lender.UI.Properties   BackgroundPrimary
 �  ��   BackgroundSecondary
 �  ��	   BackgroundAccent
	 �r���$��Delete��5j   )   $��0 5 0 5q�5l   )   $��Center=�5m   )   

 � Tag
 5k   )   �� *LoanId+5n   )   �� 5p   &   -   5        $��0��5p   -   $��2��6:   #��[ 5q   )   $
��Show��5r   )   $��0 5 0 5q�5t   )   $��Center=�5u   )   
 5s   )   �� *LoanId+5v   )   5w   #   5x      5y      5{      5|      5~      �� 5�   
   -   5        $��CreateNewProfileButton��5�      $��3��5�      $��3��5�        FancyFabButton#��[ 5�      $��+��5�      $��40��5�      $��40��6   $��20(�5�      $
��Left=�5�      $	��Top=�5�      $��5q�5�      $��5q�5�      $��Center=�5�      $��Center=�6/   6S   5�      5�      