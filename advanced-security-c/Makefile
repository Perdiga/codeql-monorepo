# Define the compiler
CC = gcc

# Define the target executable
TARGET = hello

# Define compile-time flags
CFLAGS = -Wall -Wextra -std=c11

# Define all object files
OBJS = main.o

# Default rule to build the executable
all: $(TARGET)

# Rule to build the target executable
$(TARGET): $(OBJS)
	$(CC) $(CFLAGS) -o $(TARGET) $(OBJS)

# Rule to build the main.o file
main.o: main.c
	$(CC) $(CFLAGS) -c main.c

# Clean rule to remove generated files
clean:
	rm -f $(TARGET) $(OBJS)