#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <stdbool.h>

#define TABLE_SIZE 1009
#define NULL_ITEM -1
#define DELETED_ITEM -2
#define ITEM_NAME_SIZE 32
#define SUCCESS 0
#define INSERT_ALREADY_EXIST -1
#define TABLE_FULL -2
#define SELECT_NO_ROW -3
#define DELETE_NO_ROW -4
#define UPDATE_NO_ROW -5

struct DataItem
{
    int code;
    char name;
    int price;
};

struct DataItem *hashArray[TABLE_SIZE];
struct DataItem *dummyItem;

int hashKey(int itemCode)
{
    return itemCode % TABLE_SIZE;
}
int insertItem(int itemCode, char itemName, int itemPrice)
{
    struct DataItem *item = (struct DataItem *)malloc(sizeof(struct DataItem));
    item->code = itemCode;
    item->name = itemName;
    item->price = itemPrice;

    //lay gia tri hash
    int hashIndex = hashKey(itemCode);

    //di chuyen trong mang cho toi khi gap mot o trong (empty cell) hoac o bi xoa
    while (hashArray[hashIndex] != NULL && hashArray[hashIndex]->code != -1)
    {
        //di chuyen toi o tiep theo
        ++hashIndex;

        //bao quanh hash table
        hashIndex %= TABLE_SIZE;
    }

    hashArray[hashIndex] = item;
}

void dumpItems()
{
    int i = 0;

    for (i = 0; i < TABLE_SIZE; i++)
    {

        if (hashArray[i] != NULL)
            printf(" (%d,%c,%d)", hashArray[i]->code, hashArray[i]->name, hashArray[i]->price);
        else
            printf(" ~~ ");
    }

    printf("\n");
}

int main()
{
    dummyItem = (struct DataItem *)malloc(sizeof(struct DataItem));
    dummyItem->code = -1;
    dummyItem->name = -1;
    dummyItem->price = -1;
    char test = 'C';
    insertItem(100, test, 10000);

    dumpItems();
}