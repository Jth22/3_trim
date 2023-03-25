<?php
      function calculaDescuento($precio, $descuento = 1)
    {
        return ($precio -($precio * $descuento));
    }
    
    function cuenta($a, $b)
    {
        $coma = 0;
        if ($a < $b)
        {
            $n = $a;
            $m = $b;
        }
        else
        {
            $n = $b;
            $m = $a;
        }
        for($i = $n ; $i <= $m ; $i++)
        {
            if ($coma > 0)
                echo ",";
            echo $i;
            $coma++;
        }
    }

    function intercambia(&$a, &$b)
    {
        $aux = $a;
        $a = $b;
        $b = $aux; 
    }

    function saludo($n)
    {
        echo "Hola, ".$n;
    }

?>