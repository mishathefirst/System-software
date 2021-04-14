#include "../headers/user_interface.h"
#include "../headers/mode.h"
#include "../headers/partition.h"

int main(int argc, char* argv[]) {

    struct program args = get_args(argc, argv);
    if (args.mode == UNDEFINED){
        printf("Incorrect arguments of the programme.\n");
        printf("\t-m - mode of the programme. 1 - Partitions. 2 - EXT3 filesystem.\n");
    }else if (args.mode == PARTITIONS) {
        get_partitions();
    }else if (args.mode == EXT3){
        if (entrance(args.path) == 1) printf("Произошла ошибка.\n");
    }
    return 0;
}
