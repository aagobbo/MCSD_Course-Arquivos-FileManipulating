using System;
using System.Collections.Generic;
using System.IO;

namespace Mind.Arquivos.Dominio
{
    public abstract class VarredorEstrutura
    {
        public static FileSystemInfo[] VarreDiretorio(string caminho)
        {
            List<string> resultado = new List<string>();
            if (!Directory.Exists(caminho))
                throw new Exception("não existe essa pasta");
            DirectoryInfo diretorio = new DirectoryInfo(caminho);
            return diretorio.GetFileSystemInfos("*", SearchOption.AllDirectories);

        }


    }
}
