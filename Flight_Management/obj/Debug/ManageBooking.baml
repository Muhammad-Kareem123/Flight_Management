   M S B A M L   `   `   `  ����L  HFlight_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Flight_ManagementFlight_Management  5      %    Flight_Management.ManageBooking   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Flight_Management     5        N� Title$  ManageBooking��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6$   $��2��61   $��Center=�6E   $��Center=�6`   $��30(�6}   Booking Management6�   �� 5   
   -   5        $��0��5      $��3��6!   $��44,65,44,11q�6.   $��25(�6C   .��6f   Update6n   �� 5   
   $��1��6   $��3��6!   $��44,65,44,11q�6.   $��25(�6C   .��6Q   Delete6Y   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dg��5   4   $��1��6   $��2��6    6@   �� 5   
   $��44,31,103,30q�6   $��2��6(   $��BookingDate��65   $��25(�6H   �� 5   
   $��74,31,74,30q�6   $��2��6'   $��1��64   $��PersonID��6D   $��25(�6T   5      5      