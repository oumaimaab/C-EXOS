   M S B A M L   `   `   `  ����D  @WPF PREPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_PREPA	WPF_PREPA  5	   	   c _System.Windows.Interactivity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5
   	   h dMicrosoft.Expression.Interactions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�`clr-namespace:Microsoft.Expression.Interactivity.Core;assembly=Microsoft.Expression.Interactions'Microsoft.Expression.Interactivity.Core 6e   �aclr-namespace:Microsoft.Expression.Interactivity.Media;assembly=Microsoft.Expression.Interactions(Microsoft.Expression.Interactivity.Media 5          WPF_PREPA.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hi:http://schemas.microsoft.com/expression/2010/interactivity     5   	   Hei9http://schemas.microsoft.com/expression/2010/interactions     5   	   )localclr-namespace:WPF_PREPA     5	   	   _i1Pclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5
   	   oic`clr-namespace:Microsoft.Expression.Interactivity.Core;assembly=Microsoft.Expression.Interactions     6e   qei1aclr-namespace:Microsoft.Expression.Interactivity.Media;assembly=Microsoft.Expression.Interactions     5        � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5         
hoverStyle �� Triggers P� Property P� Value �� Property �� Value  
multiStyle ]� 
Conditions �� Property	 �� Value  	dataStyle
 �� Binding �� ElementName �� Value  
checkboxTr  
dataStyle1��%v  &	        &	      &	 J    &	 V    &	 i    �� 5   
    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �  ��6;   5      5      �� 5   
    5      ]� 5       5      �� 5       �@J�IsMouseOver	 . 6E   �� 5       �@J�	IsFocused	 . 6C   ./�5      ��  � ��
 �  ��6;   5      5       �� 5!   
    5"      �� 5#      
 6   �� *Text+$	 txt�� trigger6H   .a�5$      ��  � ��
 ��� �6;   5%      �� 5&      
 6   �� *	IsChecked+$ check�� true6O   .a�5'      ��  � ��
 �  ��6;   5(      5*      �� 5+   
   6   �� 5.   
    5/      �� 50      
 6   �� *Text+$ t1�� trigger6G   .a�51      ��  � �� 65   �� *Text+$ t2���� 52       � �� 65   �� *Text+$ t3��53      56      57      .��58      � -   5         �Name$
 grid��58      .+�59   
   �� $��Trigger��6   #��[  6#   $
��Left=�6G   $��	10,10,0,0q�6b   $	��Top=�6u   $	��211��6�   $��23.667��6�   �� 5:   
   $��MultiTrigger��6   #��[ 6(   $
��Left=�6L   $��	10,52,0,0q�6g   $	��Top=�6z   $	��211��6�   $��22��6�   �� 5;   
   -   5         ��Name$	 txt��5;      #��[ 6   $
��Left=�6B   $��19��6]   $��	10,91,0,0q�6i    �� TextWrapping$
 Wrap=�6|   $��DataTrigger��6�   $	��Top=�6�   $	��211��6�   �� 5<   
   -   5         ��Name$ check��5<      $�� ��6"   $
��Left=�6-   $��226,93.901,0,0q�6H   $	��Top=�6`   �� 5=   
   -   5         ��Name$ button��5=      $��Button��6!   $
��Left=�62   $��10,126.333,0,0q�6M   $	��Top=�6e   $	��211��6}   .  (System.Windows.Interactivity.Interaction   Triggers 5>      /  )System.Windows.Interactivity.EventTrigger  5?      3  -System.Windows.Interactivity.EventTriggerBase   
SourceName$ button��6$      	EventName$ Click��68   .  (System.Windows.Interactivity.TriggerBase   Actions. 5@      >  8Microsoft.Expression.Interactivity.Media.PlaySoundAction     Source$ son.mp3?�6*      Volume$ 7Q�6;   5A      5C      �� 5D   
   $��Timer��6   $
��Left=�6"   $	��119��6=   $��10,161.667,0,0q�6J   $	��Top=�6b   $��276.358��6z   �� 5E   
    J� RenderTransformOrigin$ 
0.06,0.483&�6   
�������$��10,181,506.975,148.001q�6K   .+�5F      �� $��start��6   $��0,0,186.666,0q�6%   �� 5G      $	��End��6   $��0,0,186.666,0q�6#   5H      �� 5I   
   -   5        $��	nameLabel��5I      $��347,9,353.333,373.667q�6#   .��6B   _Name:6J   �� 5J   
   -   5        $ textb1��5J      $
��Left=�6F   $��23��6a   $��
406,13,0,0q�6m   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6"   �� *Name+ �� Mode$ TwoWay=�6�   �� 5K   
   -   5        $��ageLabel��5K      $��347,47,353.333,328.667q�6"   .��6B   _Age:6I   �� 5L   
   -   5        $ textbage��5L      $
��Left=�6F   $��23��6a   $��
406,43,0,0q�6m   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6$   �� *Age+$ TwoWay=�6�   �� 5M   
   -	   5        $
��Show��5M      $
��Left=�66   $��
420,71,0,0q�6Q   $	��Top=�6e   $��75��6}   �� 5N   
   -
   5        $��	textLabel��5N      $��347,108,353.333,267.667q�6#   .��6D   
Font size:6P   �� 5O   
   -   5        $��combo��5O      $
��Left=�6    $��445,108,0,0q�6;   $	��Top=�6P   $	��120��6h   .@�5P      �� .��6   126   �� 5Q      .��6   226   �� 5R      .��6   326   5S      �� 5T   
   -   5        $
 font��5T      $��salam��6    $
��Left=�6z   $��23��6�   $��397,147,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6-   �� $ combo�� �� Path$ SelectedItem.Content�$ OneWay=�6�   �� 5U   
   -   5        $ t1��5U   B   #��[ 6   $
��Left=�6O   $��23��6j   $��397,256.333,0,0q�6v   $
 Wrap=�6�   $��TextBox1��6�   $	��Top=�6�   $	��120��6�   .��6�   5X      �� 5Y   
   -   5        $ t2��5Y      $
��Left=�6   $��23��69   $��607.333,256.333,0,0q�6E   $
 Wrap=�6b   $��TextBox2��6v   $	��Top=�6�   $	��120��6�   �� 5Z   
   -   5        $ t3��5Z      $
��Left=�6   $��23��6:   $��499.333,307.667,0,0q�6F   $
 Wrap=�6c   $��TextBox3��6w   $	��Top=�6�   $	��120��6�   5]      5`      