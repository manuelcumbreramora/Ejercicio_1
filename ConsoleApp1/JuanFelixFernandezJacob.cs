using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class JuanFelixFernandezJacob
    {
        JuanFelixFernandezJacob()
        {
            // Esta línea la meto yo a 16-4 para indicar al profesor que puedo hacer un pull al repositorio del ejericio 1.

            /*
             * Comandos hechos antes de hacer pull origin:
             * 
             * 
            juan.fernandezjacob@PLX300000000410 MINGW64 ~
            $ cd Proyectos/

            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos
            $ cd ej1tema8/

            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
            $ ls
            ConsoleApp1/  ConsoleApp1.sln

            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
            $ ls -a
            ./  ../  .git/  .gitignore  .vs/  ConsoleApp1/  ConsoleApp1.sln

            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
            $ git status
            On branch master
            Your branch is up to date with 'origin/master'.

            Changes not staged for commit:
            (use "git add <file>..." to update what will be committed)
            (use "git restore <file>..." to discard changes in working directory)
            modified:   ConsoleApp1/JuanFelixFernandezJacob.cs

            no changes added to commit (use "git add" and/or "git commit -a")

            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
            $ git add ConsoleApp1/JuanFelixFernandezJacob.cs

            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
            $ git status
            On branch master
            Your branch is up to date with 'origin/master'.

            Changes to be committed:
            (use "git restore --staged <file>..." to unstage)
            modified:   ConsoleApp1/JuanFelixFernandezJacob.cs


            juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)

            $ git push origin
To https://github.com/manuelcumbreramora/Ejercicio_1.git
 ! [rejected]        master -> master (fetch first)
error: failed to push some refs to 'https://github.com/manuelcumbreramora/Ejercicio_1.git'
hint: Updates were rejected because the remote contains work that you do
hint: not have locally. This is usually caused by another repository pushing
hint: to the same ref. You may want to first integrate the remote changes
hint: (e.g., 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
$ git fetch
remote: Enumerating objects: 150, done.
remote: Counting objects: 100% (130/130), done.
remote: Compressing objects: 100% (44/44), done.
remote: Total 97 (delta 66), reused 81 (delta 51), pack-reused 0
Unpacking objects: 100% (97/97), 10.14 KiB | 46.00 KiB/s, done.
From https://github.com/manuelcumbreramora/Ejercicio_1
   4bb57b3..f76f49d  master            -> origin/master
 * [new branch]      Alvaro            -> origin/Alvaro
 * [new branch]      Kike              -> origin/Kike
 * [new branch]      RamaManuelAntonio -> origin/RamaManuelAntonio
 * [new branch]      dev_jesus_prueba  -> origin/dev_jesus_prueba

juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
$ git rebase origin/master
error: cannot rebase: You have unstaged changes.
error: additionally, your index contains uncommitted changes.
error: Please commit or stash them.

juan.fernandezjacob@PLX300000000410 MINGW64 ~/Proyectos/ej1tema8 (master)
$ git commit -m 'Modificado mi fichero'
[master 69535f0] Modificado mi fichero
 1 file changed, 1 insertion(+), 1 deletion(-)
                */
        }
    }
}
