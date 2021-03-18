#pragma once

#define SYS_BLOCK_DIR "/sys/block/"
#define DRIVE_PATTERN "^((sd|hd)[a-z])|(nvme[0-9])"

int listMode();

int shellMode(char *name);
