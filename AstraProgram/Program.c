#include <stdio.h>
#include <dirent.h>


int main(int argc, char** argv) {
    struct dirent *ep;
    DIR *dir = opendir("./dev");
    if (dir != NULL) {
        while (ep = readdir(dir))
            puts(ep -> d_name);
        (void) closedir(dir);
    } else {
        puts("Couldn't open the directory.");
    }

    closedir(dir);
    return 0;
}