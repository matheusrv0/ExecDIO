import java.util.Scanner;

    public class Contador {
            public static void main(String[] args) {
                Scanner sc = new Scanner(System.in);

                System.out.println("Digite um numero: ");
                    int num = sc.nextInt();
                System.out.println("Digite um numero: ");
                    int num2 = sc.nextInt();

                    try {
                        contar(num,num2);
                    }
                        catch(ParametrosInvalidosException exception) {
                            System.out.println(exception.getMessage());
                        }

                sc.close();
            }
                    static void contar (int num, int num2) throws  ParametrosInvalidosException{
                         if (num >= num2) {
                            throw new ParametrosInvalidosException("O segundo numero tem que ser maior que o primeiro");
                         }
                                int contagem = num - num2;
                                    for (int i = 1; i <= contagem; i++) {
                                        System.out.println("Imprimeindo o numero " + i);
                                    }

    }
}
