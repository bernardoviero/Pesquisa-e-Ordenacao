package principal;


import java.util.ArrayList;

public class Agitacao {

    public static void agitacao(ArrayList<String> lista) {

        boolean houveTroca;
        int ini = 0, fim = lista.size() - 1;
        int i;
        String tmp;

        do {
            houveTroca = false;
            for (i = ini; i < fim; i++) {
                if (lista.get(i).compareTo(lista.get(i + 1)) > 0) {
                    houveTroca = true;
                    tmp = lista.get(i);
                    lista.set(i, lista.get(i + 1));
                    lista.set(i + 1, tmp);
                }
            }
            fim--;

            if (!houveTroca) {
                break;
            }
            houveTroca = false;
            for (i = fim; i > ini; i--) {
                if (lista.get(i).compareTo(lista.get(i + 1)) < 0) {
                    houveTroca = true;
                    tmp = lista.get(i);
                    lista.set(i, lista.get(i - 1));
                    lista.set(i - 1, tmp);
                }
            }
            ini++;
        } while (houveTroca && ini <= fim);
    }

    public static String exibir(ArrayList<String> lista) {
        String nomes = "";
        for (int i = 0; i < lista.size(); i++) {
            System.out.println(lista.get(i));
            nomes = nomes +"\n"+ lista.get(i);
        }
        return nomes;
    }
}
