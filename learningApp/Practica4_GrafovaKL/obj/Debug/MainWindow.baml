   M S B A M L   `   `   `  ????N  JPractica4_GrafovaKL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Practica4_GrafovaKLPractica4_GrafovaKL  5   	   $    Practica4_GrafovaKL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Practica4_GrafovaKL     5   	     ? 
ResizeMode$  NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? WindowStyle$
 None=?5	   	   $	??550??5
   	   $	??750??6    ? 	Resources 5         Profile??%A   &	        ?? 5   
   $??icons\Begemotik5.png??6    5      5      .??5      ? ???#5A5A5A ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   .+?5   
   ? $??0??6   ???#FFB546 ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $??* ?6#   ?? 5      $??* ?6#   ?? 5      $??* ?6#   ?? 5      $??60 ?6#   .+?5      ]? $??0??6   .+?5       ?? $??\icons\teoryIcon.png??6   $??10,7,0,7q?5!      ?? 5"      -   5        $??	TeoryPage??5"   *   $??Теория??6   $??20(?5#      $
??Bold"?6   ???#FFB546
??????   MyButtonStyle#??[ 5&      5*      ]? 5+      $??1??6   .+?5,      ?? $ ??\icons\pixlr-bg-result.png??6   $??0,5,0,0q?5-      ?? 5.      -   5        $??PracticePage??5.   ,   $??Практика??6   $??20(?5/      $
??Bold"?6   ???#FFB546
?????? #??[ 52      56      ]? 57      $??2??6   .+?58      ?? $??\icons\educationIcon.png??6   $??60??59      $??65??6%   ?? 5;      -   5        $??EducationPage??5;   ,   $??Обучение??6   $??20(?5<      $
??Bold"?6   ???#FFB546
?????? #??[ 5?      5C      ]? 5D      $??3??6   .+?5E      ?? $??\icons\test.png??6   $??10,5,0,5q?5F      $??40??6)   ?? 5G      -   5        $??TestPage??5H      $??Тест??5G      $
??Left=?5K      $??20(?5L      $
??Bold"?6   ???#FFB546
?????? #??[ 5O      5S      ]? 5T      $??4??6   .+?5U      ?? -   5        $??ProfilePage??5V      ???#FFB546
?????? #??[ 5Z      .??5[      C?  C? ResourceKey$ Profile??6&   5\      5_      5b       ? 5d   
   -   5        $??	mainFrame??5d   >   $??1??6     ? NavigationUIVisibility$ Hidden=?6   5f      5g      5j      