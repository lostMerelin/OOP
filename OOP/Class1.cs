using OOP;
using static System.Console;

DateTime now = DateTime.Now;

TreeNode root = new TreeNode(1);
TreeNode child1 = new TreeNode(2);
TreeNode child2 = new TreeNode(3);
TreeNode grandchild1 = new TreeNode(4);
TreeNode grandchild2 = new TreeNode(5);
TreeNode grandchild3 = new TreeNode(6);

// структура дерева
root.Children.Add(child1);
root.Children.Add(child2);
child1.Children.Add(grandchild1);
child1.Children.Add(grandchild3);
child2.Children.Add(grandchild2);

root.PrintChildren();

var europ = new EuropData();
var europDecorator = new EuropDecorator(europ);
WriteLine($"europ ({europ.Culture}): {europ.Name} {europ.GetData()}");
WriteLine($"europDecorator: {europDecorator.Name} {europDecorator.GetData()}");

var Usa = new UsaData();
var UsaDecorator = new UsaDecorator(Usa);
WriteLine($"Usa ({Usa.Culture}): {Usa.Name} {Usa.GetData()}");
WriteLine($"UsaDecorator: {UsaDecorator.Name} {UsaDecorator.GetData()}");