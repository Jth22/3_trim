<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        define('PI', 3.1416);
        $radio = 3.5;
        $resultado = PI* $radio * $radio;

        echo "El área del círculo es $resultado";
    ?>
    <p>El área del círculo es <?=$resultado?></p>
</body>
</html>