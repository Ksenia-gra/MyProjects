   M S B A M L   `   `   `  ????N  JPractica4_GrafovaKL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practica4_GrafovaKLPractica4_GrafovaKL  5      /    )Practica4_GrafovaKL.PracticeExersicesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Practica4_GrafovaKL     5        N? Title$  PracticeExersicesPage??5	      .??5      ? ???#5A5A5A ? RowDefinitions 5   
   ?? 5      $??4* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $
??1.7* ?6   .+?5   
   ?? -   5        $??	QuestCard??5       ?? CornerRadius$ 20??5      ???#D4D4D4???#D4D4D4$??7q?5   3   $??70,60q?5      $??3??5       J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         	Direction$	 270Q?6#      ShadowDepth$ 10Q?64      
BlurRadius$ 10Q?6E      Opacity$	 0.8Q?6U   z?5       ?? 5!      	 ?? ScaleX$	 1Q?6!   ._?5#      ?? -   5        $??
questPanel??5%      ???#D4D4D4.+?5&      ?? -   5        $
??Task??5&      $
??Wrap=?5'      $??20,20,20,10q?5(      $??24(?5)      $??Inter)?5*      $??	ExtraBold"?5+      Задание5.      ?? 50      -   5        $??Items??50      52      ?? 53      -   5        $??
SaveAnswer??53   1   $??50??6   $	??130??6%   $??Right=?56         SignInButtonStyle#??[  57      
???   ?$??Сохранить??59      
???????$??20(?5;      $
??Bold"?5<      $??Center=?5=      
 J? RenderTransformOrigin$
 0.5,0.5&?5>      z?5@      ?? 5A      $	 1Q?6)    ?? ScaleY$ 1Q?64    ? Triggers 5C      :? 5D       :? RoutedEvent$ 
MouseEnter??6'   .[?5E      ?? .??5F   "   ?? .??5G   &   W?  ?? TargetProperty$ RenderTransform.ScaleX?66   	 W? To$
 0.85X?6i    g? Duration$ 0:0:.3D?6s    W? EasingFunction 5H   *   0  *System.Windows.Media.Animation.QuarticEase  5I   .   5K   '   W? 5L   &   $ RenderTransform.ScaleY?66   $
 0.85X?6i   $ 0:0:.3D?6s    5M   *     5N   .   5P   '   5Q   #   5R      5U      :? 5V      $ Button.MouseLeave??6'   .[?5W      ?? .??5X   "   ?? .??5Y   &   W? $ RenderTransform.ScaleX?67   $ 0:0:.3D?6j   W? 5Z   &   $ RenderTransform.ScaleY?67   $ 0:0:.3D?6k   5[   #   5\      5]      5c      5h      5i      ?? 5m   
   $??1??6   $??0??6"   5r      ?? 5t   
   $??3??6   $??3??6)   .+?5u      ?? -   5        $??Progress??5w      $ 5??5u      ???#D4D4D4???#D4D4D4$??7q?5v   3   $
??70,0q?5y       5z        5{      $	 270Q?6'   $ 10Q?68   $ 10Q?6I   $	 0.8Q?6Y   ._?5~      ? .+?5      ?? -   5         ??Name$ 
MaskBorder??5      $ 5??61   ???#D4D4D4$??20??5?   2   ? 5?       ? Minimum$ 0Q?6"    ? Maximum$ 2Q?6.    ? Value$ 0Q?5?   .   
???   ?$??0.001q?6N   
??? ? ???6f   Z?  J? OpacityMask 5?      !? 5?       !? Visual 6*   ??  ?? ElementName$ 
MaskBorder??5?      5?      5?      5?      ?? 5?   
   $??1??6   $??1??6"   5?      ?? 5?   
   $??3??6   $??1??6'   $	??200??5?      $	??200??6!   $??25,238,172,12q?6.   $??2??6E   .+?5?      ?? $??\icons\Begemotik3.png??6   5?      5?      5?      