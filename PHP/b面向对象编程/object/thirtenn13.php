<?php
abstract class AbstractClass
{
    abstract protected function prefixName($name);
}

class ConcreteClass extends AbstractClass
{
    // ���ǵ�������Զ��常��ǩ���в����ڵĿ�ѡ����
    public function prefixName($name, $separator = ".") {
        if ($name == "Pacman") {
            $prefix = "Mr";
        } elseif ($name == "Pacwoman") {
            $prefix = "Mrs";
        } else {
            $prefix = "";
        }
        return "{$prefix}{$separator} {$name}";
    }
}
$class = new ConcreteClass;
echo $class->prefixName("Pacman"), "\n";
echo $class->prefixName("Pacwoman"), "\n";
?>